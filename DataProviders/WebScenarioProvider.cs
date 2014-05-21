using ZabbixApi.Common;
using ZabbixApi.DataModel.Common;
using ZabbixApi.DataModel.WebScenario;

namespace ZabbixApi.DataProviders
{
    public sealed class WebScenarioProvider : DataProvider
    {
        public WebScenarioProvider(ZabbixClient client) : base(client) { }

        public string[] Create(Create request)
        {
            var response = base.SendRequest<WebScenarioIds>("httptest.create", request);
            return response.httptestids;
        }

        public string[] Delete(Delete request)
        {
            var response = base.SendRequest<WebScenarioIds>("httptest.delete", request);
            return response.httptestids;
        }
        
        public WebScenario[] Get(Get request)
        {
            var response = base.SendRequest<WebScenario[]>("httptest.get", request);
            return response;
        }

        public string[] IsReadable(IsReadable request)
        {
            var response = base.SendRequest<WebScenarioIds>("httptest.isreadable", request);
            return response.httptestids;
        }

        public string[] IsWritable(IsWritable request)
        {
            var response = base.SendRequest<WebScenarioIds>("httptest.iswritable", request);
            return response.httptestids;
        }

        public string[] Update(Update request)
        {
            var response = base.SendRequest<WebScenarioIds>("httptest.update", request);
            return response.httptestids;
        }
    }
}