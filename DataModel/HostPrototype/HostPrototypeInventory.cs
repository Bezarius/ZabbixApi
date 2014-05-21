namespace ZabbixApi.DataModel.HostPrototype
{
    public class HostPrototypeInventory
    {
        /// <summary>
        /// Host prototype inventory population mode.
        /// Possible values are:
        /// -1 - disabled;
        /// 0 - (default) manual;
        /// 1 - automatic.
        /// </summary>
        public int inventory_mode;
    }
}