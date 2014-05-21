using System.Linq;
using ZabbixApi.DataModel.Item;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ItemAgent
    {
        private readonly ItemProvider _provider;

        public ItemAgent(ZabbixClient zabbixClient)
        {
            _provider = new ItemProvider(zabbixClient);
        }

        public Item[] GetByHostId(int hostid)
        {
            var response = _provider.Get(new Get
            {
                monitored = true,
                hostids = new[] { hostid },
            });
            return response;
        }

        public Item[] GetByHostIds(int[] hostids)
        {
            var response = _provider.Get(new Get
                {
                    monitored = true,
                    hostids = hostids,
                });
            return response;
        }

        public Item[] GetByHostName(string host)
        {
            var response = _provider.Get(new Get
            {
                monitored = true,
                host = host,
            });
            return response;
        }

        public Item[] GetObjectsByHostName(string host)
        {
            var response = _provider.GetObjects(new GetObjects
                {
                    host = new[] { host }
                });
            return response;
        }
        public Item GetById(int id)
        {
            var response = GetByIds(new int[] {id});
            return response != null && response.Any() ? response[0] : null;
        }

        public Item[] GetByIds(int[] ids)
        {
            var response = _provider.Get(new Get
            {
                itemids = ids,
                output = "extend",
            });
            return response;
        }
    }
}