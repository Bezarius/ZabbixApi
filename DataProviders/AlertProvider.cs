using ZabbixApi.Common;
using ZabbixApi.DataModel.Alert;

namespace ZabbixApi.DataProviders
{
    public sealed class AlertProvider : DataProvider
    {
        public AlertProvider(ZabbixClient client) : base(client) { }

        public Alert[] Get(Get request)
        {
            var response = base.SendRequest<Alert[]>("alert.get", request);
            return response;
        }
    }
}