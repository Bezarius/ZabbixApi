using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.TriggerPrototype;

namespace ZabbixApi.DataProviders
{
    internal sealed class TriggerPrototypeProvider : DataProvider
    {
        public TriggerPrototypeProvider(ZabbixClient client) : base(client) { }


        public string[] Create(Create request)
        {
            var response = base.SendRequest<TriggerPrototypeIds>("triggerprototype.create", request);
            return response.triggerids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<TriggerPrototypeIds>("triggerprototype.delete", request);
            return response.triggerids;
        }

        public TriggerPrototype[] Get(Get request)
        {
            var response = base.SendRequest<TriggerPrototype[]>("triggerprototype.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<TriggerPrototypeIds>("triggerprototype.update", request);
            return response.triggerids;
        }
    }
}