using ZabbixApi.Common;
using ZabbixApi.DataModel.DiscoveredService;

namespace ZabbixApi.DataProviders
{
    public sealed class DiscoveredServiceProvider : DataProvider
    {
        public DiscoveredServiceProvider(ZabbixClient client) : base(client) { }

        public DiscoveredService[] Get(Get request)
        {
            var response = base.SendRequest<DiscoveredService[]>("dservice.get", request);
            return response;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("dservice.exists", request);
            return response;
        }
    }
}