using ZabbixApi.DataModel.Action;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ActionAgent
    {
        private readonly ActionProvider _provider;

        public ActionAgent(ZabbixClient zabbixClient)
        {
            _provider = new ActionProvider(zabbixClient);
        }

        public Action[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}