using ZabbixApi.Common;
using ZabbixApi.DataModel.Application;
using ZabbixApi.DataModel.Common;

namespace ZabbixApi.DataProviders
{
    public sealed class ApplicationProvider : DataProvider
    {
        public ApplicationProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ApplicationIds>("application.create", request);
            return response.applicationids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ApplicationIds>("application.delete", request);
            return response.applicationids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("application.exists", request);
            return response;
        }

        public Application[] Get(Get request)
        {
            var response = base.SendRequest<Application[]>("application.get", request);
            return response;
        }

        public string[] MassAdd(MassAdd request)
        {
            var response = base.SendRequest<ApplicationIds>("application.massadd", request);
            return response.applicationids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ApplicationIds>("application.update", request);
            return response.applicationids;
        }
    }
}