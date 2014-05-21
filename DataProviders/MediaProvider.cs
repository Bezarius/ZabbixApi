using ZabbixApi.Common;
using ZabbixApi.DataModel.Media;

namespace ZabbixApi.DataProviders
{
    public sealed class MediaProvider : DataProvider
    {
        public MediaProvider(ZabbixClient client) : base(client) { }

        public Media[] Get(Get request)
        {
            var response = base.SendRequest<Media[]>("media.get", request);
            return response;
        }
    }
}