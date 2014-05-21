namespace ZabbixApi.DataModel.IconMap
{
    public class IconMapping
    {
        /// <summary>
        /// </summary>
        /// <param name="iconid">ID of the icon used by the icon mapping.</param>
        /// <param name="expression">Expression to match the inventory field against.</param>
        /// <param name="inventory_link">ID of the host inventory field. Refer to the host inventory object for a list of supported inventory fields.</param>
        public IconMapping(string iconid, string expression, int inventory_link)
        {
            this.iconid = iconid;
            this.expression = expression;
            this.inventory_link = inventory_link;
        }

        /// <summary>
        ///  ID of the icon map.
        /// </summary>
        public string iconmappingid;

        /// <summary>
        /// ID of the icon used by the icon mapping.
        /// </summary>
        public string iconid;

        /// <summary>
        /// Expression to match the inventory field against.
        /// </summary>
        public string expression;

        /// <summary>
        /// ID of the host inventory field. Refer to the host inventory object for a list of supported inventory fields.
        /// </summary>
        public int inventory_link;

        /// <summary>
        ///  ID of the icon map that the icon mapping belongs to.
        /// </summary>
        public string iconmapid;

        /// <summary>
        /// Position of the icon mapping in the icon map.
        /// Default:  0.
        /// </summary>
        public int sortorder;
    }
}