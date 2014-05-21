using ZabbixApi.DataModel.Media;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class MediaAgent
    {
        private readonly MediaProvider _provider;

        public MediaAgent(ZabbixClient zabbixClient)
        {
            _provider = new MediaProvider(zabbixClient);
        }

        public Media[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}