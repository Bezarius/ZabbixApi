using ZabbixApi.DataModel.TemplateScreen;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class TemplateScreenAgent
    {
        private readonly TemplateScreenProvider _provider;

        public TemplateScreenAgent(ZabbixClient zabbixClient)
        {
            _provider = new TemplateScreenProvider(zabbixClient);
        }

        public TemplateScreen[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}