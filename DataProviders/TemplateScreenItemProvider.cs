using ZabbixApi.Common;
using ZabbixApi.DataModel.TemplateScreenItem;

namespace ZabbixApi.DataProviders
{
    public sealed class TemplateScreenItemProvider : DataProvider
    {
        public TemplateScreenItemProvider(ZabbixClient client) : base(client) { }

        public TemplateScreenItem[] Get(Get request)
        {
            var response = base.SendRequest<TemplateScreenItem[]>("templatescreenitem.get", request);
            return response;
        }
    }
}