namespace ZabbixApi.DataModel.Map
{
    public class MapURL
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Link caption.</param>
        /// <param name="url">Link URL.</param>
        public MapURL(string name, string url)
        {
            this.name = name;
            this.url = url;
        }


        /// <summary>
        ///  ID of the map URL.
        /// </summary>
        public string sysmapurlid;

        /// <summary>
        /// Link caption.
        /// </summary>
        public string name;

        /// <summary>
        /// Link URL.
        /// </summary>
        public string url;

        /// <summary>
        /// 
        ///Type of map element for which the URL will be available. Refer to the map element "type" property for a list of supported types.
        /// Default:
        /// 0.
        /// </summary>
        public int elementtype;

        /// <summary>
        /// ID of the map that the URL belongs to.
        /// </summary>
        public string sysmapid;
    }
}