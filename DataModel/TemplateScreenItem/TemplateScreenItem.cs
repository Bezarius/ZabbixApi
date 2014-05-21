namespace ZabbixApi.DataModel.TemplateScreenItem
{
    public class TemplateScreenItem
    {
        /// <summary>
        /// </summary>
        /// <param name="colspan">Number of columns the template screen item will span across.</param>
        /// <param name="resourceid">
        ///ID of the object from the parent template displayed on the template screen item. Depending on the type of screen item, the resourceid property can reference different objects. Unused by clock and URL template screen items.
        /// Note:
        /// the resourceid property always references an object used in the parent template object, even if the screen item itself is inherited on a host or template.</param>
        /// <param name="resourcetype">
        ///Type of template screen item.
        /// Possible values:
        /// 0 - graph;
        /// 1 - simple graph;
        /// 3 - plain text;
        /// 7 - clock;
        /// 11 - URL.</param>
        /// <param name="rowspan">Number or rows the template screen item will span across.</param>
        /// <param name="screenid">ID of the template screen that the item belongs to.</param>
        public TemplateScreenItem(int colspan, string resourceid, int resourcetype, int rowspan, string screenid)
        {
            this.colspan = colspan;
            this.resourceid = resourceid;
            this.resourcetype = resourcetype;
            this.rowspan = rowspan;
            this.screenid = screenid;
        }

        /// <summary>
        ///  ID of the template screen item.
        /// </summary>
        public string screenitemid;

        /// <summary>
        /// Number of columns the template screen item will span across.
        /// </summary>
        public int colspan;

        /// <summary>
        /// 
        ///ID of the object from the parent template displayed on the template screen item. Depending on the type of screen item, the resourceid property can reference different objects. Unused by clock and URL template screen items.
        /// Note:
        /// the resourceid property always references an object used in the parent template object, even if the screen item itself is inherited on a host or template.
        /// </summary>
        public string resourceid;

        /// <summary>
        /// Type of template screen item.
        /// Possible values:
        /// 0 - graph;
        /// 1 - simple graph;
        /// 3 - plain text;
        /// 7 - clock;
        /// 11 - URL.
        /// </summary>
        public int resourcetype;

        /// <summary>
        /// Number or rows the template screen item will span across.
        /// </summary>
        public int rowspan;

        /// <summary>
        /// ID of the template screen that the item belongs to.
        /// </summary>
        public string screenid;

        /// <summary>
        /// Number of lines to display on the template screen item.
        /// Default: 25.
        /// </summary>
        public int elements;

        /// <summary>
        /// Specifies how the template screen item must be aligned horizontally in the cell.
        /// Possible values:
        /// 0 - (default) center;
        /// 1 - left;
        /// 2 - right.
        /// </summary>
        public int halign;

        /// <summary>
        /// Height of the template screen item in pixels.
        /// Default: 200.
        /// </summary>
        public int height;

        /// <summary>
        /// Template screen item display option.
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
        /// URL of the webpage to be displayed in the template screen item. Used by URL template screen items.
        /// </summary>
        public string url;

        /// <summary>
        /// Specifies how the template screen item must be aligned vertically in the cell.
        /// Possible values:
        /// 0 - (default) middle;
        /// 1 - top;
        /// 2 - bottom.
        /// </summary>
        public int valign;

        /// <summary>
        /// Width of the template screen item in pixels.
        /// Default: 320.
        /// </summary>
        public int width;

        /// <summary>
        /// X-coordinates of the template screen item on the screen, from left to right.
        /// Default: 0.
        /// </summary>
        public int x;

        /// <summary>
        /// Y-coordinates of the template screen item on the screen, from top to bottom.
        /// Default: 0.
        /// </summary>
        public int y;
    }
}
