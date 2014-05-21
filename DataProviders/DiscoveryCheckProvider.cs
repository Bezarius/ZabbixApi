using ZabbixApi.Common;
using ZabbixApi.DataModel.DiscoveryCheck;

namespace ZabbixApi.DataProviders
{
    public sealed class DiscoveryCheckProvider : DataProvider
    {
        public DiscoveryCheckProvider(ZabbixClient client) : base(client) { }

        public DiscoveryCheck[] Get(Get request)
        {
            var response = base.SendRequest<DiscoveryCheck[]>("dcheck.get", request);
            return response;
        }
    }
}