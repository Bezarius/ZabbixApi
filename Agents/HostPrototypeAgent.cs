using ZabbixApi.DataModel.HostPrototype;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class HostPrototypeAgent
    {
        private readonly HostPrototypeProvider _provider;

        public HostPrototypeAgent(ZabbixClient zabbixClient)
        {
            _provider = new HostPrototypeProvider(zabbixClient);
        }

        public HostPrototype[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}