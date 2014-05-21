using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Trigger;

namespace ZabbixApi.DataProviders
{
    internal sealed class TriggerProvider : DataProvider
    {
        public TriggerProvider(ZabbixClient client) : base(client) { }

        public int[] AddDependencies(AddDependencies request)
        {
            var response = base.SendRequest<TriggerIds>("trigger.adddependencies", request);
            return response.triggerids;
        }

        public int[] Create(Create request)
        {
            var response = base.SendRequest<TriggerIds>("trigger.create", request);
            return response.triggerids;
        }

        public int[] Delete(Delete request)
        {
            var response = base.SendRequest<TriggerIds>("trigger.delete", request);
            return response.triggerids;
        }

        public int[] DeleteDependencies(DeleteDependencies request)
        {
            var response = base.SendRequest<TriggerIds>("trigger.deletedependencies", request);
            return response.triggerids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("trigger.exists", request);
            return response;
        }

        public Trigger[] Get(Get request)
        {
            var response = base.SendRequest<Trigger[]>("trigger.get", request);
            return response;
        }

        public Trigger[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Trigger[]>("trigger.getobjects", request);
            return response;
        }

        public bool IsReadable(IsReadable request)
        {
            var response = base.SendRequest<bool>("trigger.isreadable", request);
            return response;
        }

        public bool IsWritable(IsWritable request)
        {
            var response = base.SendRequest<bool>("trigger.iswritable", request);
            return response;
        }

        public int[] Update(Update request)
        {
            var response = base.SendRequest<TriggerIds>("trigger.update", request);
            return response.triggerids;
        }
    }
}