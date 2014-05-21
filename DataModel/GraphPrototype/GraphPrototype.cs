namespace ZabbixApi.DataModel.GraphPrototype
{
    public class GraphPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph prototype in pixels.</param>
        /// <param name="name">Name of the graph prototype.</param>
        /// <param name="width">Width of the graph prototype in pixels.</param>
        public GraphPrototype(int height, string name, int width)
        {
            this.height = height;
            this.name = name;
            this.width = width;
        }

        /// <summary>
        ///  ID of the graph prototype.
        /// </summary>
        public string graphid;

        /// <summary>
        /// Height of the graph prototype in pixels.
        /// </summary>
        public int height;

        /// <summary>
        /// Name of the graph prototype.
        /// </summary>
        public string name;

        /// <summary>
        /// Width of the graph prototype in pixels.
        /// </summary>
        public int width;

        /// <summary>
        /// Graph prototypes's layout type.
        /// Possible values:
        /// 0 - (default) normal;
        /// 1 - stacked;
        /// 2 - pie;
        /// 3 - exploded.
        /// </summary>
        public int graphtype;

        /// <summary>
        /// Left percentile.
        /// Default: 0.
        /// </summary>
        public string percent_left;

        /// <summary>
        ///Right percentile.
        /// Default: 0.
        /// </summary>
        public string percent_right;

        /// <summary>
        /// Whether to show discovered pie and exploded graphs in 3D.
        /// Possible values:
        /// 0 - (default) show in 2D;
        /// 1 - show in 3D.
        /// </summary>
        public int show_3d;

        /// <summary>
        /// Whether to show the legend on the discovered graph.
        /// Possible values:
        /// 0 - hide;
        /// 1 - (default) show.
        /// </summary>
        public int show_legend;

        /// <summary>
        /// Whether to show the working time on the discovered graph.
        /// Possible values:
        /// 0 - hide;
        /// 1 - (default) show.
        /// </summary>
        public int show_work_period;

        /// <summary>
        ///  ID of the parent template graph prototype.
        /// </summary>
        public string templateid;

        /// <summary>
        /// The fixed maximum value for the Y axis.
        /// </summary>
        public string yaxismax;

        /// <summary>
        /// The fixed minimum value for the Y axis.
        /// </summary>
        public string yaxismin;

        /// <summary>
        /// ID of the item that is used as the maximum value for the Y axis.
        /// </summary>
        public string ymax_itemid;

        /// <summary>
        /// Maximum value calculation method for the Y axis.
        /// Possible values:
        /// 0 - (default) calculated;
        /// 1 - fixed;
        /// 2 - item.
        /// </summary>
        public int ymax_type;

        /// <summary>
        /// ID of the item that is used as the minimum value for the Y axis.
        /// </summary>
        public string ymin_itemid;

        /// <summary>
        /// Minimum value calculation method for the Y axis.
        /// Possible values:
        /// 0 - (default) calculated;
        /// 1 - fixed;
        /// 2 - item.
        /// </summary>
        public int ymin_type;
    }
}
