using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Host;

namespace ZabbixApi.DataProviders
{
    internal sealed class HostProvider : DataProvider
    {
        public HostProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<HostIds>("host.create", request);
            return response.hostids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<HostIds>("host.delete", request);
            return response.hostids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("host.exists", request);
            return response;
        }

        public Host[] Get(Get request)
        {
            var response = base.SendRequest<Host[]>("host.get", request);
            return response;
        }

        public Host[] Get(GetObjects request)
        {
            var response = base.SendRequest<Host[]>("host.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<HostIds>("host.isreadable", request);
            return response.hostids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<HostIds>("host.iswritable", request);
            return response.hostids;
        }

        public string[] MassAdd(MassAdd request)
        {
            var response = base.SendRequest<HostIds>("host.massadd", request);
            return response.hostids;
        }

        public string[] MassRemove(MassRemove request)
        {
            var response = base.SendRequest<HostIds>("host.massremove", request);
            return response.hostids;
        }

        public string[] MassUpdate(MassUpdate request)
        {
            var response = base.SendRequest<HostIds>("host.massupdate", request);
            return response.hostids;
        }
        

        public string[] Update(Update request)
        {
            var response = base.SendRequest<HostIds>("host.update", request);
            return response.hostids;
        }
    }
}