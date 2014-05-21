namespace ZabbixApi.DataModel.Item
{
    public class Update : Item
    {
        /// <summary>
        /// IDs of the applications to add the item to.
        /// </summary>
        public Application.Application[] applications;
    }
}