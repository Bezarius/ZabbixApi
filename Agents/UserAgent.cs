using ZabbixApi.DataModel.User;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class UserAgent
    {
        private readonly UserProvider _provider;

        public UserAgent(ZabbixClient zabbixClient)
        {
            _provider = new UserProvider(zabbixClient);
        }

        public User[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}