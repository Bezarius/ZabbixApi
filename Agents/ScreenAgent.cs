using ZabbixApi.DataModel.Screen;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ScreenAgent
    {
        private readonly ScreenProvider _provider;

        public ScreenAgent(ZabbixClient zabbixClient)
        {
            _provider = new ScreenProvider(zabbixClient);
        }

        public Screen[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}