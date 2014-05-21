using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Item;

namespace ZabbixApi.DataProviders
{
    public sealed class ItemProvider : DataProvider
    {
        public ItemProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ItemIds>("item.create", request);
            return response.itemids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ItemIds>("item.delete", request);
            return response.itemids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("item.exists", request);
            return response;
        }

        public Item[] Get(Get request)
        {
            var response = base.SendRequest<Item[]>("item.get", request);
            return response;
        }

        public Item[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Item[]>("item.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ItemIds>("item.isreadable", request);
            return response.itemids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ItemIds>("item.iswritable", request);
            return response.itemids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ItemIds>("item.update", request);
            return response.itemids;
        }
    }
}