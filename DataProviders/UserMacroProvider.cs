using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.UserMacro;

namespace ZabbixApi.DataProviders
{
    internal sealed class UserMacroProvider: DataProvider
    {
        public UserMacroProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.create", request);
            return response.hostmacroids;
        }

        public string[] CreateGlobal(CreateGlobal request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.createglobal", request);
            return response.hostmacroids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.delete", request);
            return response.hostmacroids;
        }

        public string[] DeleteGlobal(Delete request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.deleteglobal", request);
            return response.hostmacroids;
        }

        public HostMacro[] Get(Get request)
        {
            var response = base.SendRequest<HostMacro[]>("usermacro.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.update", request);
            return response.hostmacroids;
        }

        public string[] UpdateGlobal(UpdateGlobal request)
        {
            var response = base.SendRequest<HostMacroIds>("usermacro.updateglobal", request);
            return response.hostmacroids;
        }
    }
}