using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Template;

namespace ZabbixApi.DataProviders
{
    public sealed class TemplateProvider : DataProvider
    {
        public TemplateProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<TemplateIds>("template.create", request);
            return response.templateids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<TemplateIds>("template.delete", request);
            return response.templateids;
        }

        public Template[] Get(Get request)
        {
            var response = base.SendRequest<Template[]>("template.get", request);
            return response;
        }

        public Template[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Template[]>("template.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<TemplateIds>("template.isreadable", request);
            return response.templateids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<TemplateIds>("template.iswritable", request);
            return response.templateids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<TemplateIds>("template.update", request);
            return response.templateids;
        }
    }
}