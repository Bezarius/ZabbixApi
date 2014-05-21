namespace ZabbixApi.Common
{

    public class BaseResponse<T> : BaseMessage
    {
        public T result;
        public Error error;
    }
}