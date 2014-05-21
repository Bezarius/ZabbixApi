using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.HostGroup;

namespace ZabbixApi.DataProviders
{
    internal sealed class HostGroupProvider : DataProvider
    {
        public HostGroupProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.create", request);
            return response.groupids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.delete", request);
            return response.groupids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("hostgroup.exists", request);
            return response;
        }

        public HostGroup[] Get(Get request)
        {
            var response = base.SendRequest<HostGroup[]>("hostgroup.get", request);
            return response;
        }

        public HostGroup[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<HostGroup[]>("hostgroup.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.isreadable", request);
            return response.groupids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.iswritable", request);
            return response.groupids;
        }

        public string[] MassAdd(MassAdd request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.massadd", request);
            return response.groupids;
        }

        public string[] MassRemove(MassRemove request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.massremove", request);
            return response.groupids;
        }

        public string[] MassUpdate(MassUpdate request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.massupdate", request);
            return response.groupids;
        }


        public string[] Update(Update request)
        {
            var response = base.SendRequest<HostGroupIds>("hostgroup.update", request);
            return response.groupids;
        }
    }
}