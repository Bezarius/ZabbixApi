using ZabbixApi.Common;
using ZabbixApi.DataModel.History;

namespace ZabbixApi.DataProviders
{
    internal sealed class HistoryProvider : DataProvider
    {
        public HistoryProvider(ZabbixClient client) : base(client) { }

        public HistoryBase[] Get(Get request)
        {
            var response = base.SendRequest<HistoryBase[]>("history.get", request);
            return response;
        }
    }
}