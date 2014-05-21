using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Image;

namespace ZabbixApi.DataProviders
{
    public sealed class ImageProvider : DataProvider
    {
        public ImageProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ImageIds>("image.create", request);
            return response.imageids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ImageIds>("image.delete", request);
            return response.imageids;
        }

        public Image[] Get(Get request)
        {
            var response = base.SendRequest<Image[]>("image.get", request);
            return response;
        }

        public Image[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Image[]>("image.getobjects", request);
            return response;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ImageIds>("image.update", request);
            return response.imageids;
        }
    }
}