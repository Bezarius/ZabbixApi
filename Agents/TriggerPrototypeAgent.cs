using ZabbixApi.DataModel.TriggerPrototype;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class TriggerPrototypeAgent
    {
        private readonly TriggerPrototypeProvider _provider;

        public TriggerPrototypeAgent(ZabbixClient zabbixClient)
        {
            _provider = new TriggerPrototypeProvider(zabbixClient);
        }

        public TriggerPrototype[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    expandExpression = true,
                    output = "extend",
                    selectHosts = "extend",
                    selectFunctions = "extend",
                    selectDiscoveryRule = "extend",
                });
            return response;
        }

        public TriggerPrototype[] GetByHostId(int hostId)
        {
            var response = _provider.Get(new Get
            {
                hostids = new[] { hostId },
                output = "extend",
            });
            return response;
        }
    }
}