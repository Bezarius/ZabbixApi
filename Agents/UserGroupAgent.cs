using ZabbixApi.DataModel.UserGroup;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class UserGroupAgent
    {
        private readonly UserGroupProvider _provider;

        public UserGroupAgent(ZabbixClient zabbixClient)
        {
            _provider = new UserGroupProvider(zabbixClient);
        }

        public UserGroup[] GetAll()
        {
            var response = _provider.Get(new Get
                {
                    output = "extend",
                });
            return response;
        }
    }
}