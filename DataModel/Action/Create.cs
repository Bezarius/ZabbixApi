namespace ZabbixApi.DataModel.Action
{
    public class Create
    {
        /// <summary>
        /// </summary>
        /// <param name="operations">Action operations to create for the action.</param>
        public Create(string[] operations)
        {
            this.operations = operations;
        }
        
        /// <summary>
        /// Action operations to create for the action.
        /// </summary>
        public string[] operations;

        /// <summary>
        /// Action conditions to create for the action.
        /// </summary>
        public string[] conditions;
    }
}