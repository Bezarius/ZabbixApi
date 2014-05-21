using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Graph;

namespace ZabbixApi.DataProviders
{
    public sealed class GraphProvider : DataProvider
    {
        public GraphProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<GraphIds>("graph.create", request);
            return response.graphids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<GraphIds>("graph.delete", request);
            return response.graphids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("graph.exists", request);
            return response;
        }

        public Graph[] Get(Get request)
        {
            var response = base.SendRequest<Graph[]>("graph.get", request);
            return response;
        }

        public Graph[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Graph[]>("graph.getobjects", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<GraphIds>("graph.update", request);
            return response.graphids;
        }
    }
}