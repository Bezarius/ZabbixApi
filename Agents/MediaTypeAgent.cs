using ZabbixApi.DataModel.MediaType;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class MediaTypeAgent
    {
        private readonly MediaTypeProvider _provider;

        public MediaTypeAgent(ZabbixClient zabbixClient)
        {
            _provider = new MediaTypeProvider(zabbixClient);
        }

        public MediaType[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}