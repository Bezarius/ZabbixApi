namespace ZabbixApi.DataModel.GraphItem
{
    public class GraphItem
    {
        /// <summary>
        /// </summary>
        /// <param name="color">Graph item's draw color as a hexadecimal color code.</param>
        /// <param name="itemid">ID of the item.</param>
        public GraphItem(string color, string itemid)
        {
            this.color = color;
            this.itemid = itemid;
        }


        /// <summary>
        ///  ID of the graph item.
        /// </summary>
        public string gitemid;

        /// <summary>
        /// Graph item's draw color as a hexadecimal color code.
        /// </summary>
        public string color;

        /// <summary>
        /// ID of the item.
        /// </summary>
        public string itemid;

        /// <summary>
        /// Value of the item that will be displayed.
        /// Possible values:
        /// 1 - minimum value;
        /// 2 - (default) average value;
        /// 4 - maximum value;
        /// 9 - last value, used only by pie and exploded graphs.
        /// </summary>
        public int calc_fnc;

        /// <summary>
        /// Draw style of the graph item.
        /// Possible values:
        /// 0 - (default) line;
        /// 1 - filled region;
        /// 2 - bold line;
        /// 3 - dot;
        /// 4 - dashed line;
        /// 5 - gradient line.
        /// </summary>
        public int drawtype;

        /// <summary>
        /// ID of the graph that the graph item belongs to.
        /// </summary>
        public string graphid;

        /// <summary>
        ///Position of the item in the graph.
        /// Default: 0.
        /// </summary>
        public int sortorder;

        /// <summary>
        /// Type of graph item.
        /// Possible values:
        /// 0 - (default) simple;
        /// 2 - graph sum, used only by pie and exploded graphs.
        /// </summary>
        public int type;

        /// <summary>
        ///Side of the graph where the graph item's Y scale will be drawn.
        /// Possible values:
        /// 0 - (default) left side;
        /// 1 - right side.
        /// </summary>
        public int yaxisside;
    }
}