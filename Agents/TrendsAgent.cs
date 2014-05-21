using System;
using ZabbixApi.DataModel.Trends;
using ZabbixApi.DataProviders;
using ZabbixApi.Helpers;

namespace ZabbixApi.Agents
{
    public class TrendsAgent
    {
        private readonly TrendsProvider _provider;

        public TrendsAgent(ZabbixClient zabbixClient)
        {
            _provider = new TrendsProvider(zabbixClient);
        }

        public Trend[] GetAll()
        {
            var response = _provider.Get(new Get());
            return response;
        }

        public Trend[] GetInRange(int[] itemids, long from, long to, TrendType trendType = TrendType.Float)
        {
            var response = _provider.Get(new Get
            {
                itemids = itemids,
                time_from = from,
                time_till = to,
                history = trendType
            });
            return response;
        }

        public Trend[] GetLastsForPeriod(TimeSpan span, int[] itemids = null, TrendType trendType = TrendType.Float)
        {
            return GetInRange(itemids, (DateTime.UtcNow - span), DateTime.UtcNow, trendType);
        }

        public Trend[] GetInRange(int[] itemids, DateTime from, DateTime to, TrendType trendType = TrendType.Float)
        {
            if (from == null || to == null)
                throw new ArgumentNullException();
            return GetInRange(itemids, from.ToUnixTime(), to.ToUnixTime(), trendType);
        }

        public Trend[] GetInRange(DateTime from, DateTime to, TrendType trendType = TrendType.Float)
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
                    history = trendType
                });
            return response;
        }
    }
}