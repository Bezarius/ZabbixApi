using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.HostInterface;

namespace ZabbixApi.DataProviders
{
    internal sealed class HostInterfaceProvider : DataProvider
    {
        public HostInterfaceProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.create", request);
            return response.interfaceids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.delete", request);
            return response.interfaceids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("hostinterface.exists", request);
            return response;
        }

        public HostInterface[] Get(Get request)
        {
            var response = base.SendRequest<HostInterface[]>("hostinterface.get", request);
            return response;
        }

        public string[] MassAdd(MassAdd request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.massadd", request);
            return response.interfaceids;
        }

        public string[] MassRemove(MassRemove request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.massremove", request);
            return response.interfaceids;
        }

        public string[] ReplaceHostInterfaces(ReplaceHostInterfaces request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.replacehostinterfaces", request);
            return response.interfaceids;
        }
        
        public string[] Update(Update request)
        {
            var response = base.SendRequest<HostInterfaceIds>("hostinterface.update", request);
            return response.interfaceids;
        }
    }
}