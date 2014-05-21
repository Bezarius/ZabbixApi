using ZabbixApi.DataModel.UserMacro;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class UserMacroAgent
    {
        private readonly UserMacroProvider _provider;

        public UserMacroAgent(ZabbixClient zabbixClient)
        {
            _provider = new UserMacroProvider(zabbixClient);
        }

        public HostMacro[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}