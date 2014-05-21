namespace ZabbixApi.DataModel.Map
{
    public class MapLink
    {
        /// <summary>
        /// </summary>
        /// <param name="selementid1">ID of the first map element linked on one end.</param>
        /// <param name="selementid2">ID of the first map element linked on the other end.</param>
        public MapLink(string selementid1, string selementid2)
        {
            this.selementid1 = selementid1;
            this.selementid2 = selementid2;
        }

        /// <summary>
        ///  ID of the map link.
        /// </summary>
        public string linkid;

        /// <summary>
        /// ID of the first map element linked on one end.
        /// </summary>
        public string selementid1;

        /// <summary>
        /// ID of the first map element linked on the other end.
        /// </summary>
        public string selementid2;

        /// <summary>
        /// Line color as a hexadecimal color code.
        /// Default:
        /// 000000.
        /// </summary>
        public string color;

        /// <summary>
        /// Link line draw style.
        /// Possible values:
        /// 0 - (default) line;
        /// 2 - bold line;
        /// 3 - dotted line;
        /// 4 - dashed line.
        /// </summary>
        public int drawtype;

        /// <summary>
        /// Link label.
        /// </summary>
        public string label;

        /// <summary>
        /// Map link triggers to use as link status indicators. 
        /// </summary>
        public MapLinkTrigger[] linktriggers;

        /// <summary>
        /// ID of the map the link belongs to.
        /// </summary>
        public string sysmapid;
    }
}