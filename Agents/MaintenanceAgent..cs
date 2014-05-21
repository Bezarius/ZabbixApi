using ZabbixApi.DataModel.Maintenance;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class MaintenanceAgent
    {
        private readonly MaintenanceProvider _provider;

        public MaintenanceAgent(ZabbixClient zabbixClient)
        {
            _provider = new MaintenanceProvider(zabbixClient);
        }

        public Maintenance[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}