using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.UserGroup;

namespace ZabbixApi.DataProviders
{
    internal sealed class UserGroupProvider : DataProvider
    {
        public UserGroupProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.create", request);
            return response.usrgrpids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.delete", request);
            return response.usrgrpids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("usergroup.exists", request);
            return response;
        }

        public UserGroup[] Get(Get request)
        {
            var response = base.SendRequest<UserGroup[]>("usergroup.get", request);
            return response;
        }

        public GetObjects[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<GetObjects[]>("usergroup.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.isreadable", request);
            return response.usrgrpids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.iswritable", request);
            return response.usrgrpids;
        }

        public string[] MassAdd(MassAdd request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.massadd", request);
            return response.usrgrpids;
        }
        
        public string[] MassUpdate(MassUpdate request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.massupdate", request);
            return response.usrgrpids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<UserGroupIds>("usergroup.update", request);
            return response.usrgrpids;
        }
    }
}