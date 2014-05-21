using ZabbixApi.DataModel.Alert;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class AlertAgent
    {
        private readonly AlertProvider _provider;

        public AlertAgent(ZabbixClient zabbixClient)
        {
            _provider = new AlertProvider(zabbixClient);
        }

        public Alert[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}