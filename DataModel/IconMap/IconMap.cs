namespace ZabbixApi.DataModel.IconMap
{
    public class IconMap
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the icon map.</param>
        public IconMap(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the icon map.
        /// </summary>
        public string iconmapid;

        /// <summary>
        /// ID of the default icon.
        /// </summary>
        public string default_iconid;

        /// <summary>
        /// Name of the icon map.
        /// </summary>
        public string name;
    }
}
