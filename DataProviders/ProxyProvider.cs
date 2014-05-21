using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.Proxy;

namespace ZabbixApi.DataProviders
{
    public sealed class ProxyProvider : DataProvider
    {
        public ProxyProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<ProxyIds>("proxy.create", request);
            return response.proxyids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<ProxyIds>("proxy.delete", request);
            return response.proxyids;
        }

        public DataModel.Proxy.Proxy[] Get(Get request)
        {
            var response = base.SendRequest<DataModel.Proxy.Proxy[]>("proxy.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<ProxyIds>("proxy.isreadable", request);
            return response.proxyids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<ProxyIds>("proxy.iswritable", request);
            return response.proxyids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<ProxyIds>("proxy.update", request);
            return response.proxyids;
        }
    }
}