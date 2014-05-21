using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.ITService;



namespace ZabbixApi.DataProviders
{
    internal sealed class ITServiceProvider : DataProvider
    {
        public ITServiceProvider(ZabbixClient client) : base(client) { }

        public string[] AddDependencies(AddDependencies request)
        {
            var response = base.SendRequest<ServiceIds>("service.adddependencies", request);
            return response.serviceids;
        }

        public string[] AddTimes(AddTimes request)
        {
            var response = base.SendRequest<ServiceIds>("service.addtimes", request);
            return response.serviceids;
        }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ServiceIds>("service.create", request);
            return response.serviceids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ServiceIds>("service.delete", request);
            return response.serviceids;
        }

        public string[] DeleteDependencies(DeleteDependencies request)
        {
            var response = base.SendRequest<ServiceIds>("service.deletedependencies", request);
            return response.serviceids;
        }

        public string[] DeleteTimes(DeleteTimes request)
        {
            var response = base.SendRequest<ServiceIds>("service.deletetimes", request);
            return response.serviceids;
        }

        public ITService[] Get(Get request)
        {
            var response = base.SendRequest<ITService[]>("service.get", request);
            return response;
        }

        public ITServiceInfo Get(GetSLA request)
        {
            var response = base.SendRequest<ITServiceInfo>("service.getsla", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ServiceIds>("service.isreadable", request);
            return response.serviceids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ServiceIds>("service.iswritable", request);
            return response.serviceids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ServiceIds>("service.update", request);
            return response.serviceids;
        }
    }
}