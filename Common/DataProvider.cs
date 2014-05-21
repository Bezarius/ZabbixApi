using System;

namespace ZabbixApi.Common
{
    public class DataProvider
    {
        private readonly ZabbixClient _client;
        private string _method;
        private object _params;
        private readonly object _syncRoot;

        public DataProvider() { }

        public DataProvider(ZabbixClient client)
        {
            _client = client;
            _syncRoot = new object();
        }

        protected T SendRequest<T>(string method, object param)
        {
            _method = method;
            _params = param;
            lock (_syncRoot)
            {
                try
                {
                    var response = _client.Call<BaseResponse<T>>(_method, _params);
                    if (response != null)
                    {
                        if (response.error != null)
                        {
                            throw new Exception(string.Format(@"{0}\n{1}", response.error.message, response.error.data));
                        }
                        return response.result;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Ошибка исполнения запроса!", e);
                }
            }
            return default(T);
        }
    }
}