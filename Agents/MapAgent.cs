using ZabbixApi.DataModel.Map;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class MapAgent
    {
        private readonly MapProvider _provider;

        public MapAgent(ZabbixClient zabbixClient)
        {
            _provider = new MapProvider(zabbixClient);
        }

        public Map[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}