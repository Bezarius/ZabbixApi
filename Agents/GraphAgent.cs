using ZabbixApi.DataModel.Graph;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class GraphAgent
    {
        private readonly GraphProvider _provider;

        public GraphAgent(ZabbixClient zabbixClient)
        {
            _provider = new GraphProvider(zabbixClient);
        }

        public Graph[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}