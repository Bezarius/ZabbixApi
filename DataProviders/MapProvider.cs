using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Map;

namespace ZabbixApi.DataProviders
{
    public sealed class MapProvider : DataProvider
    {
        public MapProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<MapIds>("map.create", request);
            return response.mapids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<MapIds>("map.delete", request);
            return response.mapids;
        }

        public Map[] Get(Get request)
        {
            var response = base.SendRequest<Map[]>("map.get", request);
            return response;
        }

        public Map[] GetObjects(GetObjects request)
        {
            var response = base.SendRequest<Map[]>("map.getobjects", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<MapIds>("map.isreadable", request);
            return response.mapids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<MapIds>("map.iswritable", request);
            return response.mapids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<MapIds>("map.update", request);
            return response.mapids;
        }
    }
}