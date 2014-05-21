using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Media
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only media with the given IDs.
        /// </summary>
        public string[] mediaids;

        /// <summary>
        /// Return only media that are used by users in the given user groups.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Return only media that are used by the given users.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// Return only media that use the given media types.
        /// </summary>
        public string[] mediatypeids;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// mediaid, userid and mediatypeid.
        /// </summary>
        public string[] sortfield;
    }
}