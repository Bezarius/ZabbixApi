using ZabbixApi.Common;
using ZabbixApi.DataModel.Trends;

namespace ZabbixApi.DataProviders
{
    internal sealed class TrendsProvider : DataProvider
    {
        public TrendsProvider(ZabbixClient client) : base(client) { }

        public Trend[] Get(Get request)
        {
            var response = base.SendRequest<Trend[]>("trends.get", request);
            return response;
        }
    }
}