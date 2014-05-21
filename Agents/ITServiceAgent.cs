using ZabbixApi.DataModel.ITService;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ITServiceAgent
    {
        private readonly ITServiceProvider _provider;

        public ITServiceAgent(ZabbixClient zabbixClient)
        {
            _provider = new ITServiceProvider(zabbixClient);
        }

        public ITService[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}