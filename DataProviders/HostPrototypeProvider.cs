using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.HostPrototype;

namespace ZabbixApi.DataProviders
{
    public sealed class HostPrototypeProvider : DataProvider
    {
        public HostPrototypeProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<HostPrototypeIds>("hostprototype.create", request);
            return response.hostids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<HostPrototypeIds>("hostprototype.delete", request);
            return response.hostids;
        }

        public HostPrototype[] Get(Get request)
        {
            var response = base.SendRequest<HostPrototype[]>("hostprototype.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<HostPrototypeIds>("hostprototype.isreadable", request);
            return response.hostids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<HostPrototypeIds>("hostprototype.iswritable", request);
            return response.hostids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<HostPrototypeIds>("hostprototype.update", request);
            return response.hostids;
        }
    }
}