namespace ZabbixApi.DataModel.ScreenItem
{
    public class ScreenItem
    {
        /// <summary>
        /// </summary>
        /// <param name="resourcetype">
        ///Type of screen item.
        /// Possible values:
        /// 0 - graph;
        /// 1 - simple graph;
        /// 2 - map;
        /// 3 - plain text;
        /// 4 - hosts info;
        /// 5 - triggers info;
        /// 6 - server info;
        /// 7 - clock;
        /// 8 - screen;
        /// 10 - data overview;
        /// 11 - URL;
        /// 12 - history of actions;
        /// 13 - history of events;
        /// 14 - status of host group triggers;
        /// 15 - system status;
        /// 16 - status of host triggers.</param>
        /// <param name="screenid">ID of the screen that the item belongs to.</param>
        public ScreenItem(int resourcetype, string screenid)
        {
            this.resourcetype = resourcetype;
            this.screenid = screenid;
        }
        
        /// <summary>
        ///  ID of the screen item.
        /// </summary>
        public string screenitemid;

        /// <summary>
        /// Number of columns the screen item will span across.
        /// </summary>
        public int colspan;

        /// <summary>
        /// Type of screen item.
        /// Possible values:
        /// 0 - graph;
        /// 1 - simple graph;
        /// 2 - map;
        /// 3 - plain text;
        /// 4 - hosts info;
        /// 5 - triggers info;
        /// 6 - server info;
        /// 7 - clock;
        /// 8 - screen;
        /// 10 - data overview;
        /// 11 - URL;
        /// 12 - history of actions;
        /// 13 - history of events;
        /// 14 - status of host group triggers;
        /// 15 - system status;
        /// 16 - status of host triggers.
        /// </summary>
        public int resourcetype;

        /// <summary>
        /// Number or rows the screen item will span across.
        /// </summary>
        public int rowspan;

        /// <summary>
        /// ID of the screen that the item belongs to.
        /// </summary>
        public string screenid;

        /// <summary>
        /// Whether the screen item is dynamic.
        /// Possible values:
        /// 0 - (default) not dynamic;
        /// 1 - dynamic.
        /// </summary>
        public int dynamic;

        /// <summary>
        /// Number of lines to display on the screen item.
        /// Default: 25.
        /// </summary>
        public int elements;

        /// <summary>
        /// Specifies how the screen item must be aligned horizontally in the cell.
        /// Possible values:
        /// 0 - (default) center;
        /// 1 - left;
        /// 2 - right.
        /// </summary>
        public int halign;

        /// <summary>
        /// Height of the screen item in pixels.
        /// Default: 200.
        /// </summary>
        public int height;

        /// <summary>
        /// ID of the object displayed on the screen item. Depending on the type of a screen item, the resourceid property can reference different objects. Required for data overview, graph, map, plain text, screen, simple graph and trigger overview screen items. Unused by local and server time clocks, history of actions, history of events, hosts info, server info, system status and URL screen items.
        /// </summary>
        public string resourceid;

        /// <summary>
        /// Order in which actions or triggers must be sorted.
        /// Possible values for history of actions screen elements:
        /// 3 - time, ascending;
        /// 4 - time, descending;
        /// 5 - type, ascending;
        /// 6 - type, descending;
        /// 7 - status, ascending;
        /// 8 - status, descending;
        /// 9 - retries left, ascending;
        /// 10 - retries left, descending;
        /// 11 - recipient, ascending;
        /// 12 - recipient, descending.
        /// Possible values for status of host group triggers and status of host triggers screen items:
        /// 0 - (default) last change, descending;
        /// 1 - severity, descending;
        /// 2 - host, ascending.
        /// </summary>
        public int sort_triggers;

        /// <summary>
        /// Screen item display option.
        /// Possible values for data overview and triggers overview screen items:
        /// 0 - (default) display hosts on the left side;
        /// 1 - display hosts on the top.
        /// Possible values for hosts info and triggers info screen elements:
        /// 0 - (default) horizontal layout;
        /// 1 - vertical layout.
        /// Possible values for clock screen items:
        /// 0 - (default) local time;
        /// 1 - server time;
        /// 2 - host time.
        /// Possible values for plain text screen items:
        /// 0 - (default) display values as plain text;
        /// 1 - display values as HTML.
        /// </summary>
        public int style;

        /// <summary>
        /// URL of the webpage to be displayed in the screen item. Used by URL screen items.
        /// </summary>
        public string url;

        /// <summary>
        /// Specifies how the screen item must be aligned vertically in the cell.
        /// Possible values:
        /// 0 - (default) middle;
        /// 1 - top;
        /// 2 - bottom.
        /// </summary>
        public int valign;

        /// <summary>
        /// Width of the screen item in pixels.
        /// Default:
        /// 320.
        /// </summary>
        public int width;

        /// <summary>
        /// X-coordinates of the screen item on the screen, from left to right.
        /// Default:
        /// 0.
        /// </summary>
        public int x;

        /// <summary>
        /// Y-coordinates of the screen item on the screen, from top to bottom.
        /// Default:
        /// 0.
        /// </summary>
        public int y;
    }
}
