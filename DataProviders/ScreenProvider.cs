using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Screen;

namespace ZabbixApi.DataProviders
{
    public sealed class ScreenProvider : DataProvider
    {
        public ScreenProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ScreenIds>("screen.create", request);
            return response.screenids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ScreenIds>("screen.delete", request);
            return response.screenids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("screen.exists", request);
            return response;
        }

        public Screen[] Get(Get request)
        {
            var response = base.SendRequest<Screen[]>("screen.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ScreenIds>("screen.update", request);
            return response.screenids;
        }
    }
}