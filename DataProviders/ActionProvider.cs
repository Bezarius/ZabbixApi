using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Action;

namespace ZabbixApi.DataProviders
{
    public sealed class ActionProvider : DataProvider
    {
        public ActionProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ActionIds>("action.create", request);
            return response.actionids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ActionIds>("action.delete", request);
            return response.actionids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("action.exists", request);
            return response;
        }

        public Action[] Get(Get request)
        {
            var response = base.SendRequest<Action[]>("action.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ActionIds>("action.update", request);
            return response.actionids;
        }
    }
}