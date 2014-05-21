using ZabbixApi.DataModel.DiscoveryRule;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class DiscoveryRuleAgent
    {
        private readonly DiscoveryRuleProvider _provider;

        public DiscoveryRuleAgent(ZabbixClient zabbixClient)
        {
            _provider = new DiscoveryRuleProvider(zabbixClient);
        }

        public DiscoveryRule[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}