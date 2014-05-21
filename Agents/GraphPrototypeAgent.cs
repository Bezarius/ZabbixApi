using ZabbixApi.DataModel.GraphPrototype;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class GraphPrototypeAgent
    {
        private readonly GraphPrototypeProvider _provider;

        public GraphPrototypeAgent(ZabbixClient zabbixClient)
        {
            _provider = new GraphPrototypeProvider(zabbixClient);
        }

        public GraphPrototype[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}