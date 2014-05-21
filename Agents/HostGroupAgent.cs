using ZabbixApi.DataModel.HostGroup;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class HostGroupAgent
    {
        private readonly HostGroupProvider _provider;

        public HostGroupAgent(ZabbixClient zabbixClient)
        {
            _provider = new HostGroupProvider(zabbixClient);
        }

        public HostGroup[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}