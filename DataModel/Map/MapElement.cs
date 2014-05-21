namespace ZabbixApi.DataModel.Map
{
    public class MapElement
    {
        /// <summary>
        /// </summary>
        /// <param name="elementid">ID of the object that the map element represents. Required for host, host group, trigger and map type elements.</param>
        /// <param name="elementtype">
        /// Type of map element.
        /// Possible values:
        /// 0 - host;
        /// 1 - map;
        /// 2 - trigger;
        /// 3 - host group;
        /// 4 - image.</param>
        /// <param name="iconid_off">ID of the image used to display the element in default state.</param>
        public MapElement(string elementid, int elementtype, string iconid_off)
        {
            this.elementid = elementid;
            this.elementtype = elementtype;
            this.iconid_off = iconid_off;
        }


        /// <summary>
        ///  ID of the map element.
        /// </summary>
        public string selementid;

        /// <summary>
        /// ID of the object that the map element represents. Required for host, host group, trigger and map type elements.
        /// </summary>
        public string elementid;

        /// <summary>
        /// Type of map element.
        /// Possible values:
        /// 0 - host;
        /// 1 - map;
        /// 2 - trigger;
        /// 3 - host group;
        /// 4 - image.
        /// </summary>
        public int elementtype;

        /// <summary>
        /// ID of the image used to display the element in default state.
        /// </summary>
        public string iconid_off;

        /// <summary>
        /// How separate host group hosts should be displayed.
        /// Possible values:
        /// 0 - (default) the host group element will take up the whole map;
        /// 1 - the host group element will have a fixed size.
        /// </summary>
        public int areatype;

        /// <summary>
        /// How a host group element should be displayed on a map.
        /// Possible values:
        /// 0 - (default) display the host group as a single element;
        /// 1 - display each host in the group separately.
        /// </summary>
        public int elementsubtype;

        /// <summary>
        /// Height of the fixed size host group element in pixels.
        /// Default:
        /// 200.
        /// </summary>
        public int height;

        /// <summary>
        /// ID of the image used to display disabled map elements. Unused for image elements.
        /// </summary>
        public string iconid_disabled;

        /// <summary>
        /// ID of the image used to display map elements in maintenance. Unused for image elements.
        /// </summary>
        public string iconid_maintenance;

        /// <summary>
        /// ID of the image used to display map elements with problems. Unused for image elements.
        /// </summary>
        public string iconid_on;

        /// <summary>
        /// Label of the element.
        /// </summary>
        public string label;

        /// <summary>
        /// Location of the map element label.
        /// Possible values:
        /// 0 - (default) bottom;
        /// 1 - left;
        /// 2 - right;
        /// 3 - top.
        /// </summary>
        public int label_location;

        /// <summary>
        ///  ID of the map that the element belongs to.
        /// </summary>
        public string sysmapid;

        /// <summary>
        /// Map element URLs. 
        /// </summary>
        public MapElementURL[] urls;

        /// <summary>
        /// Whether icon mapping must be used for host elements.
        /// Possible values:
        /// 0 - do not use icon mapping;
        /// 1 - (default) use icon mapping.
        /// </summary>
        public int use_iconmap;

        /// <summary>
        /// Host group element placing algorithm.
        /// Possible values:
        /// 0 - (default) grid.
        /// </summary>
        public int viewtype;

        /// <summary>
        /// Width of the fixed size host group element in pixels.
        /// Default:
        /// 200.
        /// </summary>
        public int width;

        /// <summary>
        /// X-coordinates of the element in pixels.
        /// Default:
        /// 0.
        /// </summary>
        public int x;

        /// <summary>
        /// Y-coordinates of the element in pixels.
        /// Default:
        /// 0.
        /// </summary>
        public int y;
    }
}