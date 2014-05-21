using ZabbixApi.DataModel.HostInterface;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class HostInterfaceAgent
    {
        private readonly HostInterfaceProvider _provider;

        public HostInterfaceAgent(ZabbixClient zabbixClient)
        {
            _provider = new HostInterfaceProvider(zabbixClient);
        }

        public HostInterface[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }

        public HostInterface[] GetByHostId(int hostId)
        {
            var response = _provider.Get(new Get
            {
                hostids = new[] { hostId },
                output = "extend",
            });
            return response;
        }
    }
}