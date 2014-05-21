using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.ItemPrototype;

namespace ZabbixApi.DataProviders
{
    public sealed class ItemPrototypeProvider : DataProvider
    {
        public ItemPrototypeProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ItemPrototypeIds>("itemprototype.create", request);
            return response.itemids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ItemPrototypeIds>("itemprototype.delete", request);
            return response.itemids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("itemprototype.exists", request);
            return response;
        }

        public ItemPrototype[] Get(Get request)
        {
            var response = base.SendRequest<ItemPrototype[]>("itemprototype.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ItemPrototypeIds>("itemprototype.isreadable", request);
            return response.itemids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ItemPrototypeIds>("itemprototype.iswritable", request);
            return response.itemids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ItemPrototypeIds>("itemprototype.update", request);
            return response.itemids;
        }
    }
}