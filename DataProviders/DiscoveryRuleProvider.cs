using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.DiscoveryRule;

namespace ZabbixApi.DataProviders
{
    public sealed class DiscoveryRuleProvider : DataProvider
    {
        public DiscoveryRuleProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<DiscoveryRuleIds>("drule.create", request);
            return response.druleids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<DiscoveryRuleIds>("drule.delete", request);
            return response.druleids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("drule.exists", request);
            return response;
        }

        public DiscoveryRule[] Get(Get request)
        {
            var response = base.SendRequest<DiscoveryRule[]>("drule.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<DiscoveryRuleIds>("drule.isreadable", request);
            return response.druleids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<DiscoveryRuleIds>("drule.iswritable", request);
            return response.druleids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<DiscoveryRuleIds>("drule.update", request);
            return response.druleids;
        }
    }
}