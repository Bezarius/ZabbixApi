namespace ZabbixApi.DataModel.Map
{
    public class MapLinkTrigger
    {
        /// <summary>
        ///  ID of the trigger used as a link indicator.
        /// </summary>
        public MapLinkTrigger(string triggerid)
        {
            this.triggerid = triggerid;
        }

        /// <summary>
        ///  ID of the map link trigger.
        /// </summary>
        public string linktriggerid;

        /// <summary>
        /// ID of the trigger used as a link indicator.
        /// </summary>
        public string triggerid;

        /// <summary>
        /// Indicator color as a hexadecimal color code.
        /// Default:
        /// DD0000.
        /// </summary>
        public string color;

        /// <summary>
        /// Indicator draw style.
        /// Possible values:
        /// 0 - (default) line;
        /// 2 - bold line;
        /// 3 - dotted line;
        /// 4 - dashed line.
        /// </summary>
        public int drawtype;

        /// <summary>
        /// ID of the map link that the link trigger belongs to.
        /// </summary>
        public string linkid;
    }
}