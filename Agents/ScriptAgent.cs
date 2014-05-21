using ZabbixApi.DataModel.Script;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ScriptAgent
    {
        private readonly ScriptProvider _provider;

        public ScriptAgent(ZabbixClient zabbixClient)
        {
            _provider = new ScriptProvider(zabbixClient);
        }

        public Script[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}