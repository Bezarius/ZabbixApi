using ZabbixApi.Common;
using ZabbixApi.DataModel.GraphItem;

namespace ZabbixApi.DataProviders
{
    public sealed class GraphItemProvider : DataProvider
    {
        public GraphItemProvider(ZabbixClient client) : base(client) { }

        public GraphItem[] Get(Get request)
        {
            var response = base.SendRequest<GraphItem[]>("graphitem.get", request);
            return response;
        }
    }
}