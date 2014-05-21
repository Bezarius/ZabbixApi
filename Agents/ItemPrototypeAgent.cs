using ZabbixApi.DataModel.ItemPrototype;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ItemPrototypeAgent
    {
        private readonly ItemPrototypeProvider _provider;

        public ItemPrototypeAgent(ZabbixClient zabbixClient)
        {
            _provider = new ItemPrototypeProvider(zabbixClient);
        }

        public ItemPrototype[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}