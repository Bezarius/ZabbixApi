namespace ZabbixApi.DataModel.Action
{
    public class Update
    {
        /// <summary>
        /// Action conditions to replace existing conditions.
        /// </summary>
        public string[] conditions;

        /// <summary>
        /// Action operations to replace existing operations.
        /// </summary>
        public string[] operations;
    }
}