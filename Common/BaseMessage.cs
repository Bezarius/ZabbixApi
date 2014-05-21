namespace ZabbixApi.Common
{
    public class BaseMessage
    {
        public int id;
        public string jsonrpc = "2.0";
    }

    public class Interval
    {
        public long from;
        public long to;
    }
}