using ZabbixApi.DataModel.Application;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ApplicationAgent
    {
        private readonly ApplicationProvider _provider;

        public ApplicationAgent(ZabbixClient zabbixClient)
        {
            _provider = new ApplicationProvider(zabbixClient);
        }

        public Application[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }

        public Application[] GetByHostId(int hostId)
        {
            var response = _provider.Get(new Get
            {
                hostids = new[] { hostId },
                output = "extend"
            });
            return response;
        }
    }
}