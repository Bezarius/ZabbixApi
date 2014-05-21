using ZabbixApi.Common;
using ZabbixApi.DataModel.DiscoveredHost;

namespace ZabbixApi.DataProviders
{
    public class DiscoveredHostProvider : DataProvider
    {
        public DiscoveredHostProvider(ZabbixClient client) : base(client) { }

        public DiscoveredHost[] Get(Get request)
        {
            var response = base.SendRequest<DiscoveredHost[]>("dhost.get", request);
            return response;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("dhost.exists", request);
            return response;
        }
    }
}
