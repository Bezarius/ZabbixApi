using ZabbixApi.Common;

namespace ZabbixApi.DataModel.MediaType
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only media types with the given IDs.
        /// </summary>
        public string[] mediatypeids;

        /// <summary>
        /// Return only media types used by the given media.
        /// </summary>
        public string[] mediaids;

        /// <summary>
        /// Return only media types used by the given users.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// Return the users that use the media type in the users property.
        /// </summary>
        public string selectUsers;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// mediatypeid.
        /// </summary>
        public string[] sortfield;
    }
}