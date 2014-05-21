using ZabbixApi.DataModel.DiscoveredHost;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class DiscoveredHostAgent
    {
        private readonly DiscoveredHostProvider _provider;

        public DiscoveredHostAgent(ZabbixClient zabbixClient)
        {
            _provider = new DiscoveredHostProvider(zabbixClient);
        }

        public DiscoveredHost[] GetAll()
        {
            var response = _provider.Get(new Get
            {
                output = "extend",
            });
            return response;
        }

        public DiscoveredHost[] GetByIds(int[] ids)
        {
            var response = _provider.Get(new Get
            {
                dhostids = ids,
                output = "extend",
            });
            return response;
        }
    }
}