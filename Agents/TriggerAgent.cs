using System.Globalization;
using System.Linq;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Trigger;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class TriggerAgent
    {
        private readonly TriggerProvider _triggers;

        public TriggerAgent(ZabbixClient zabbixClient)
        {
            _triggers = new TriggerProvider(zabbixClient);
        }

        public Trigger[] GetAll()
        {
            var response = _triggers.Get(new Get
            {
                expandExpression = true,
                sortfield = new[] { "lastchange" }
            });
            return response;
        }

        public Trigger GetById(int id)
        {
            var response = GetByIds(new[] {id});
            return response != null && response.Any() ? response[0] : null;
        }

        public Trigger[] GetByIds(int[] ids)
        {
            var response = _triggers.Get(new Get
            {
                expandExpression = true,
                triggerids = ids,
                editable = true
            });
            return response;
        }

        public void UpdateTriggerExpression(int triggerId, string expression)
        {
            _triggers.Update(new Update
                {
                    expression = expression,
                    triggerid = triggerId
                });
        }

        public bool IsWritable(int triggerId)
        {
            return _triggers.IsWritable(new IsWritable { triggerId });
        }

        public int CloneTrigger(int triggerId)
        {
            var t = GetById(triggerId);

            var response = _triggers.Create(new Create(t.description, t.expression)
                {
                    hosts = t.hosts,
                    functions = t.functions,
                    comments = t.comments,
                    flags = t.flags,
                    priority = t.priority,
                    templateid = t.templateid,
                    url = t.url,
                    type = t.type
                });
            return response != null && response.Any() ? response[0] : 0;
        }

        public Trigger[] GetByHostIds(int[] hostids)
        {
            var response = _triggers.Get(new Get
            {
                expandExpression = true,
                hostids = hostids
            });
            return response;
        }

        public Trigger[] GetByHostId(int hostid)
        {
            var response = _triggers.Get(new Get
            {
                expandExpression = true,
                hostids = new[] { hostid }
            });
            return response;
        }

        public Trigger[] GetByItemIds(int[] itemdIds)
        {
            var response = _triggers.Get(new Get
            {
                expandExpression = true,
                itemids = itemdIds
            });
            return response;
        }

        /// <summary>
        /// Возвращает идентификаторы источников данных(items) для триггеров
        /// </summary>
        /// <param name="triggerIds">Массив идентификаторов триггеров</param>
        /// <returns></returns>
        public int[] GetDependItemIdsByIds(int[] triggerIds)
        {
            var triggers = GetByIds(triggerIds);
            var itemIds = triggers.SelectMany(x => x.functions.Select(y => y.itemid)).ToArray();
            return itemIds;
        }

        /// <summary>
        /// Возвращает массив уникальных идентификаторов источников данных(items) для триггеров
        /// </summary>
        /// <param name="hostId">Массив идентификаторов триггеров</param>
        /// <returns></returns>
        public int[] GetDependItemIdsByHostId(int hostId)
        {
            var triggers = GetByHostId(hostId);
            var itemIds = triggers.SelectMany(x => x.functions.Select(y => y.itemid)).Distinct().ToArray();
            return itemIds;
        }
    }
}
