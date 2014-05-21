namespace ZabbixApi.DataModel.Map
{
    public class MapElementURL
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Link caption.</param>
        /// <param name="url">Link URL.</param>
        public MapElementURL(string name, string url)
        {
            this.name = name;
            this.url = url;
        }

        /// <summary>
        ///  ID of the map element URL.
        /// </summary>
        public string sysmapelementurlid;

        /// <summary>
        /// Link caption.
        /// </summary>
        public string name;

        /// <summary>
        /// Link URL.
        /// </summary>
        public string url;

        /// <summary>
        /// ID of the map element that the URL belongs to.
        /// </summary>
        public string selementid;
    }
}