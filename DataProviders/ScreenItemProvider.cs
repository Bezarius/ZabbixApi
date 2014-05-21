using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.ScreenItem;

namespace ZabbixApi.DataProviders
{
    public sealed class ScreenItemProvider : DataProvider
    {
        public ScreenItemProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.create", request);
            return response.screenitemids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.delete", request);
            return response.screenitemids;
        }


        public ScreenItem[] Get(Get request)
        {
            var response = base.SendRequest<ScreenItem[]>("screenitem.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.isreadable", request);
            return response.screenitemids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.iswritable", request);
            return response.screenitemids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.update", request);
            return response.screenitemids;
        }

        public string[] UpdateByPosition(UpdateByPosition request)
        {
            var response = base.SendRequest<ScreenItemIds>("screenitem.updatebyposition", request);
            return response.screenitemids;
        }
    }
}