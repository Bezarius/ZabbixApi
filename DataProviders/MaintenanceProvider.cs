using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Maintenance;

namespace ZabbixApi.DataProviders
{
    public sealed class MaintenanceProvider : DataProvider
    {
        public MaintenanceProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<MaintenanceIds>("maintenance.create", request);
            return response.maintenanceids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<MaintenanceIds>("maintenance.delete", request);
            return response.maintenanceids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("maintenance.exists", request);
            return response;
        }

        public Maintenance[] Get(Get request)
        {
            var response = base.SendRequest<Maintenance[]>("maintenance.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<MaintenanceIds>("maintenance.update", request);
            return response.maintenanceids;
        }
    }
}