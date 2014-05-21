using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.LLDRule;

namespace ZabbixApi.DataProviders
{
    internal sealed class LLDRuleProvider : DataProvider
    {
        public LLDRuleProvider(ZabbixClient client) : base(client) { }

        public string[] Copy(Copy request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.create", request);
            return response.itemids;
        }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.create", request);
            return response.itemids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.delete", request);
            return response.itemids;
        }

        public bool Exists(Exists request)
        {
            var response = base.SendRequest<bool>("discoveryrule.exists", request);
            return response;
        }

        public LLDRule[] Get(Get request)
        {
            var response = base.SendRequest<LLDRule[]>("discoveryrule.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.isreadable", request);
            return response.itemids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.iswritable", request);
            return response.itemids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ItemIds>("discoveryrule.update", request);
            return response.itemids;
        }
    }
}