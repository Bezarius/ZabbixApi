using ZabbixApi.DataModel.ScreenItem;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ScreenItemAgent
    {
        private readonly ScreenItemProvider _provider;

        public ScreenItemAgent(ZabbixClient zabbixClient)
        {
            _provider = new ScreenItemProvider(zabbixClient);
        }

        public ScreenItem[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}