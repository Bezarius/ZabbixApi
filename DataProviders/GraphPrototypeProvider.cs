using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Graph;
using ZabbixApi.DataModel.GraphPrototype;
using Create = ZabbixApi.DataModel.GraphPrototype.Create;
using Exists = ZabbixApi.DataModel.GraphPrototype.Exists;
using Get = ZabbixApi.DataModel.GraphPrototype.Get;
using GetObjects = ZabbixApi.DataModel.GraphPrototype.GetObjects;
using Update = ZabbixApi.DataModel.GraphPrototype.Update;

namespace ZabbixApi.DataProviders
{
    public sealed class GraphPrototypeProvider : DataProvider
    {
        public GraphPrototypeProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<GraphIds>("graphprototype.create", request);
            return response.graphids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<GraphIds>("graphprototype.delete", request);
            return response.graphids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("graphprototype.exists", request);
            return response;
        }

        public GraphPrototype[] Get(Get request)
        {
            var response = base.SendRequest<GraphPrototype[]>("graphprototype.get", request);
            return response;
        }

        public GraphPrototype[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<GraphPrototype[]>("graphprototype.getobjects", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<GraphIds>("graphprototype.update", request);
            return response.graphids;
        }
    }
}