namespace ZabbixApi.Common
{
    public class StringResponse : BaseMessage
    {
        public string result;
        public Error error;
    }

    public class BaseRequest : BaseMessage
    {
        private static int _id = 0;
        public string auth;
        public string method;
        public object @params;

        public BaseRequest()
        {
            base.id = ++_id;
        }
    }
}