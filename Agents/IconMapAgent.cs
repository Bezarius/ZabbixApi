using ZabbixApi.DataModel.IconMap;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class IconMapAgent
    {
        private readonly IconMapProvider _provider;

        public IconMapAgent(ZabbixClient zabbixClient)
        {
            _provider = new IconMapProvider(zabbixClient);
        }

        public IconMap[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}