using ZabbixApi.DataModel.DiscoveryCheck;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class DiscoveryCheckAgent
    {
        private readonly DiscoveryCheckProvider _provider;

        public DiscoveryCheckAgent(ZabbixClient zabbixClient)
        {
            _provider = new DiscoveryCheckProvider(zabbixClient);
        }

        public DiscoveryCheck[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}