using ZabbixApi.DataModel.TemplateScreenItem;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class TemplateScreenItemAgent
    {
        private readonly TemplateScreenItemProvider _provider;

        public TemplateScreenItemAgent(ZabbixClient zabbixClient)
        {
            _provider = new TemplateScreenItemProvider(zabbixClient);
        }

        public TemplateScreenItem[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}