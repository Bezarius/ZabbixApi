using ZabbixApi.DataModel.Proxy;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ProxyAgent
    {
        private readonly ProxyProvider _provider;

        public ProxyAgent(ZabbixClient zabbixClient)
        {
            _provider = new ProxyProvider(zabbixClient);
        }

        public DataModel.Proxy.Proxy[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}