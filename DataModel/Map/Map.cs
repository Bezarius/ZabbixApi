namespace ZabbixApi.DataModel.Map
{
    public class Map
    {
        /// <summary>
        /// </summary>
        /// <param name="height">Height of the map in pixels.</param>
        /// <param name="name">Name of the map.</param>
        /// <param name="width">Width of the map in pixels.</param>
        public Map(int height, string name, int width)
        {
            this.height = height;
            this.name = name;
            this.width = width;
        }


        /// <summary>
        ///  ID of the map.
        /// </summary>
        public string sysmapid;

        /// <summary>
        /// Height of the map in pixels.
        /// </summary>
        public int height;

        /// <summary>
        /// Name of the map.
        /// </summary>
        public string name;

        /// <summary>
        /// Width of the map in pixels.
        /// </summary>
        public int width;

        /// <summary>
        /// ID of the image used as the background for the map.
        /// </summary>
        public string backgrounid;

        /// <summary>
        /// Whether to expand macros in labels when configuring the map.
        /// Possible values:
        /// 0 - (default) do not expand macros;
        /// 1 - expand macros.
        /// </summary>
        public int expand_macros;

        /// <summary>
        /// Whether the the problem trigger will be displayed for elements with a single problem.
        /// Possible values:
        /// 0 - always display the number of problems;
        /// 1 - (default) display the problem trigger if there's only one problem.
        /// </summary>
        public int expandproblem;

        /// <summary>
        /// Whether to enable grid aligning.
        /// Possible values:
        /// 0 - disable grid aligning;
        /// 1 - (default) enable grid aligning.
        /// </summary>
        public int grid_align;

        /// <summary>
        /// Whether to show the grid on the map.
        /// Possible values:
        /// 0 - do not show the grid;
        /// 1 - (default) show the grid.
        /// </summary>
        public int grid_show;

        /// <summary>
        /// Size of the map grid in pixels.
        /// Supported values:
        /// 20, 40, 50, 75 and 100.
        /// Default:
        /// 50.
        /// </summary>
        public int grid_size;

        /// <summary>
        /// Whether icon highlighting is enabled.
        /// Possible values:
        /// 0 - highlighting disabled;
        /// 1 - (default) highlighting enabled.
        /// </summary>
        public int highlight;

        /// <summary>
        /// ID of the icon map used on the map.
        /// </summary>
        public string iconmapid;

        /// <summary>
        /// Whether to enable advanced labels.
        /// Possible values:
        /// 0 - (default) disable advanced labels;
        /// 1 - enable advanced labels.
        /// </summary>
        public int label_format;

        /// <summary>
        /// Location of the map element label.
        /// Possible values:
        /// 0 - bottom;
        /// 1 - left;
        /// 2 - right;
        /// 3 - (default) top.
        /// </summary>
        public int label_location;

        /// <summary>
        /// Custom label for host elements. Required for maps with custom host label type.
        /// </summary>
        public string label_string_host;

        /// <summary>
        /// Custom label for host group elements. Required for maps with custom host group label type.
        /// </summary>
        public string label_string_hostgroup;

        /// <summary>
        /// Custom label for image elements. Required for maps with custom image label type.
        /// </summary>
        public string label_string_image;

        /// <summary>
        /// Custom label for map elements. Required for maps with custom map label type.
        /// </summary>
        public string label_string_map;

        /// <summary>
        /// Custom label for trigger elements. Required for maps with custom trigger label type.
        /// </summary>
        public string label_string_trigger;

        /// <summary>
        /// Map element label type.
        /// Possible values:
        /// 0 - label;
        /// 1 - IP address;
        /// 2 - (default) element name;
        /// 3 - status only;
        /// 4 - nothing.
        /// </summary>
        public int label_type;

        /// <summary>
        /// Label type for host elements.
        /// Possible values:
        /// 0 - label;
        /// 1 - IP address;
        /// 2 - (default) element name;
        /// 3 - status only;
        /// 4 - nothing;
        /// 5 - custom.
        /// </summary>
        public int label_type_host;

        /// <summary>
        /// Label type for host group elements.
        /// Possible values:
        /// 0 - label;
        /// 2 - (default) element name;
        /// 3 - status only;
        /// 4 - nothing;
        /// 5 - custom.
        /// </summary>
        public int label_type_hostgroup;

        /// <summary>
        /// Label type for host group elements.
        /// Possible values:
        /// 0 - label;
        /// 2 - (default) element name;
        /// 4 - nothing;
        /// 5 - custom.
        /// </summary>
        public int label_type_image;

        /// <summary>
        /// Label type for map elements.
        /// Possible values:
        /// 0 - label;
        /// 2 - (default) element name;
        /// 3 - status only;
        /// 4 - nothing;
        /// 5 - custom.
        /// </summary>
        public int label_type_map;

        /// <summary>
        /// Label type for trigger elements.
        /// Possible values:
        /// 0 - label;
        /// 2 - (default) element name;
        /// 3 - status only;
        /// 4 - nothing;
        /// 5 - custom.
        /// </summary>
        public int label_type_trigger;

        /// <summary>
        /// Whether to highlight map elements that have recently changed their status.
        /// Possible values:
        /// 0 - (default) do not highlight elements;
        /// 1 - highlight elements.
        /// </summary>
        public int markelements;

        /// <summary>
        /// How problems should be displayed.
        /// Possible values:
        /// 0 - (default) display the count of all problems;
        /// 1 - display only the count of unacknowledged problems;
        /// 2 - display the count of acknowledged and unacknowledged problems separately.
        /// </summary>
        public int show_unack;
    }
}
