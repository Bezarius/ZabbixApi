using ZabbixApi.DataModel.GraphItem;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class GraphItemAgent
    {
        private readonly GraphItemProvider _provider;

        public GraphItemAgent(ZabbixClient zabbixClient)
        {
            _provider = new GraphItemProvider(zabbixClient);
        }

        public GraphItem[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}