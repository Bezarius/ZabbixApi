using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class ConfigurationAgent
    {
        private readonly ConfigurationProvider _provider;

        public ConfigurationAgent(ZabbixClient zabbixClient)
        {
            _provider = new ConfigurationProvider(zabbixClient);
        }
    }
}