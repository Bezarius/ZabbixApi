using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.TemplateScreen;

namespace ZabbixApi.DataProviders
{
    public sealed class TemplateScreenProvider : DataProvider
    {
        public TemplateScreenProvider(ZabbixClient client) : base(client) { }

        public bool Copy(Copy request)
        {
            var response = base.SendRequest<bool>("templatescreen.copy", request);
            return response;
        }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<TemplateScreenIds>("templatescreen.create", request);
            return response.templatescreenids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<TemplateScreenIds>("templatescreen.delete", request);
            return response.templatescreenids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("templatescreen.exists", request);
            return response;
        }

        public TemplateScreen[] Get(Get request)
        {
            var response = base.SendRequest<TemplateScreen[]>("templatescreen.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<TemplateScreenIds>("templatescreen.isreadable", request);
            return response.templatescreenids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<TemplateScreenIds>("templatescreen.iswritable", request);
            return response.templatescreenids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<TemplateScreenIds>("templatescreen.update", request);
            return response.templatescreenids;
        }
    }
}