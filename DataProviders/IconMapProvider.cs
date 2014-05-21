using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.IconMap;
using Create = ZabbixApi.DataModel.IconMap.Create;
using Get = ZabbixApi.DataModel.IconMap.Get;
using Update = ZabbixApi.DataModel.IconMap.Update;

namespace ZabbixApi.DataProviders
{
    public sealed class IconMapProvider : DataProvider
    {
        public IconMapProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<IconMapIds>("iconmap.create", request);
            return response.iconmapids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<IconMapIds>("iconmap.delete", request);
            return response.iconmapids;
        }

        public IconMap[] Get(Get request)
        {
            var response = base.SendRequest<IconMap[]>("iconmap.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<IconMapIds>("iconmap.isreadable", request);
            return response.iconmapids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<IconMapIds>("iconmap.iswritable", request);
            return response.iconmapids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<IconMapIds>("iconmap.update", request);
            return response.iconmapids;
        }
    }
}