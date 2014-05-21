using System.Linq;
using ZabbixApi.DataModel.Template;
using ZabbixApi.DataProviders;

namespace ZabbixApi.Agents
{
    public class TemplateAgent 
    {
        private readonly TemplateProvider _provider;

        public TemplateAgent(ZabbixClient zabbixClient)
        {
            _provider = new TemplateProvider(zabbixClient);
        }

        public Template[] GetAll()
        {
            var response = _provider.Get(new Get
            {
                output = "extend",
            });
            return response;
        }

        public Template GetByTriggerId(int triggerId)
        {
            var response = _provider.Get(new Get
            {
                triggerids = new[] { triggerId },
                output = "extend",
            });
            return response != null && response.Any() ? response[0] : null;
        }

        public Template GetById(int templateId)
        {
            var response = _provider.Get(new Get
            {
                templateids = new[] { templateId },
                output = "extend",
            });
            return response != null && response.Any() ? response[0] : null;
        }

        public Template[] GetByHostId(int hostId)
        {
            var response = _provider.Get(new Get
            {
                hostids = new[] { hostId },
                output = "extend",
            });
            return response;
        }
    }
}