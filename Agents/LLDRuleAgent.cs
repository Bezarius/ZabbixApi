using ZabbixApi.DataModel.LLDRule;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class LLDRuleAgent
    {
        private readonly LLDRuleProvider _provider;

        public LLDRuleAgent(ZabbixClient zabbixClient)
        {
            _provider = new LLDRuleProvider(zabbixClient);
        }

        public LLDRule[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}