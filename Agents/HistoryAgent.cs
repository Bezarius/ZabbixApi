using System;
using ZabbixApi.DataModel.History;
using ZabbixApi.DataProviders;
using ZabbixApi.Helpers;

namespace ZabbixApi.Agents
{
    public class HistoryAgent
    {
        private readonly HistoryProvider _provider;

        public HistoryAgent(ZabbixClient zabbixClient)
        {
            _provider = new HistoryProvider(zabbixClient);
        }

        public HistoryBase[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    time_from = DateTime.Now.ToUnixTime(),
                    time_till = (DateTime.Now - new TimeSpan(4, 0, 0)).ToUnixTime(),
                    editable = true,
                });
            return response;
        }

        public HistoryBase[] GetHistoryByItemIds(string[] itemids, int limit = 100)
        {
            var response = _provider.Get(new Get
            {
                itemids = itemids,
                history = 3,
                limit = limit
            });
            return response;
        }

        public HistoryBase[] GetHistoryByItemIdsInRange(string[] itemids, long from, long to)
        {
            var response = _provider.Get(new Get
            {
                itemids = itemids,
                history = 3,
                time_from = from,
                time_till = to
            });
            return response;
        }

        public HistoryBase[] GetHistoryByItemIdsInRange(string[] itemids, DateTime from, DateTime to)
        {
            return GetHistoryByItemIdsInRange(itemids, from.ToUnixTime(), to.ToUnixTime());
        }

        public HistoryBase[] GetHistoryInRange(DateTime from, DateTime to)
        {
            if (from == null || to == null)
                throw new ArgumentNullException();

            if (from.Kind != DateTimeKind.Utc)
                from = from.ToUniversalTime();

            if (to.Kind != DateTimeKind.Utc)
                to = to.ToUniversalTime();

            var response = _provider.Get(new Get
            {
                time_from = from.ToUnixTime(),
                time_till = to.ToUnixTime(),
            });
            return response;
        }
    }
}