using ZabbixApi.Common;
using ZabbixApi.DataModel.Configuration;

namespace ZabbixApi.DataProviders
{
    public sealed class ConfigurationProvider : DataProvider
    {
        public ConfigurationProvider(ZabbixClient client) : base(client) { }

        public string Export(Export request)
        {
            var response = base.SendRequest<string>("configuration.export", request);
            return response;
        }

        public string Import(Import request)
        {
            var response = base.SendRequest<string>("configuration.import", request);
            return response;
        }
    }
}