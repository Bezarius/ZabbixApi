using ZabbixApi.DataModel.Host;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class HostAgent
    {
        private readonly HostProvider _provider;

        public HostAgent(ZabbixClient zabbixClient)
        {
            _provider = new HostProvider(zabbixClient);
        }

        public Host[] GetAll()
        {
            var response = _provider.Get(new Get());
            return response;
        }
    }
}