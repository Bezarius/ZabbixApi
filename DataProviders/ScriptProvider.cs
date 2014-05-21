using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Script;

namespace ZabbixApi.DataProviders
{
    public sealed class ScriptProvider : DataProvider
    {
        public ScriptProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ScriptIds>("script.create", request);
            return response.scriptids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ScriptIds>("script.delete", request);
            return response.scriptids;
        }

        public ExecuteResponse Execute(Execute request)
        {
            var response = base.SendRequest<ExecuteResponse>("script.execute", request);
            return response;
        }

        public Script[] Get(Get request)
        {
            var response = base.SendRequest<Script[]>("script.get", request);
            return response;
        }

        public GetScriptsByHostsResponse[] GetScriptsByHosts(GetScriptsByHosts request)
        {
            var response = base.SendRequest<GetScriptsByHostsResponse[]>("script.getscriptsbyhosts", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ScriptIds>("script.update", request);
            return response.scriptids;
        }
    }
}