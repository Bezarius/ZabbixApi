using ZabbixApi.DataModel.WebScenario;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class WebScenarioAgent
    {
        private readonly WebScenarioProvider _provider;

        public WebScenarioAgent(ZabbixClient zabbixClient)
        {
            _provider = new WebScenarioProvider(zabbixClient);
        }

        public WebScenario[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}