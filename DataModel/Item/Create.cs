namespace ZabbixApi.DataModel.Item
{
    public class Create : Item
    {
        /// <summary>
        /// IDs of the applications to add the item to.
        /// </summary>
        public Application.Application[] applications;
    }
}