using System;

namespace ZabbixApi.Helpers
{
    public static class UnixTime
    {
        private static readonly DateTime StartEpoch = new DateTime(1970, 1, 1, 0, 0, 0);

        public static long ToUnixTime(this DateTime time)
        {
            return (long)(time - StartEpoch).TotalSeconds;
        }

        public static DateTime FromUnixTime(this long time)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(
                time).ToLocalTime();
        }
    }
}
