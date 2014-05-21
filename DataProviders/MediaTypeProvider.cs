using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.MediaType;

namespace ZabbixApi.DataProviders
{
    public sealed class MediaTypeProvider : DataProvider
    {
        public MediaTypeProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<MediaTypeIds>("mediatype.create", request);
            return response.mediatypeids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<MediaTypeIds>("mediatype.delete", request);
            return response.mediatypeids;
        }

        public MediaType[] Get(Get request)
        {
            var response = base.SendRequest<MediaType[]>("mediatype.get", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<MediaTypeIds>("mediatype.update", request);
            return response.mediatypeids;
        }
    }
}