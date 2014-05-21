namespace ZabbixApi.DataModel.MediaType
{
    public class Update : MediaType
    {
        /// <summary>
        /// </summary>
        /// <param name="description">Name of the media type.</param>
        /// <param name="type">
        /// Transport used by the media type.
        /// Possible values:
        /// 0 - email;
        /// 1 - script;
        /// 2 - SMS;
        /// 3 - Jabber;
        /// 100 - Ez Texting.</param>
        public Update(string description, int type)
            : base(description, type)
        {
        }
    }
}