namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request allows to delete all trigger dependencies from the given triggers.
    /// </summary>
    public class DeleteDependencies
    {
        /// <summary>
        /// Triggers to delete the trigger dependencies from.
        /// </summary>
        public string[] triggerids;
    }
}