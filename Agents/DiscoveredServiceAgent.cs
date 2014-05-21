using ZabbixApi.DataModel.DiscoveredService;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class DiscoveredServiceAgent
    {
        private readonly DiscoveredServiceProvider _provider;

        public DiscoveredServiceAgent(ZabbixClient zabbixClient)
        {
            _provider = new DiscoveredServiceProvider(zabbixClient);
        }

        public DiscoveredService[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }

        public object GetByIds(int[] ids)
        {
            var response = _provider.Get(new Get
            {
                dserviceids = ids,
                output = "extend",
            });
            return response;
        }
    }
}