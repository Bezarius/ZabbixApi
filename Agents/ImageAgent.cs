using ZabbixApi.DataModel.Image;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ImageAgent
    {
        private readonly ImageProvider _provider;

        public ImageAgent(ZabbixClient zabbixClient)
        {
            _provider = new ImageProvider(zabbixClient);
        }

        public Image[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}