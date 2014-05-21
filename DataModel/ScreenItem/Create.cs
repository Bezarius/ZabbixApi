namespace ZabbixApi.DataModel.ScreenItem
{
    public class Create : ScreenItem
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
        public Create(int resourcetype, string screenid) : base(resourcetype, screenid)
        {
        }
    }
}