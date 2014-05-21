namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request allows to create new trigger dependencies.
    /// </summary>
    public class AddDependencies
    {
        /// <summary>
        /// </summary>
        /// <param name="triggerid">ID of the dependent trigger.</param>
        /// <param name="dependsOnTriggerid">ID of the trigger that the trigger depends on.</param>
        public AddDependencies(string triggerid, string dependsontriggerid)
        {
            this.triggerid = triggerid;
            this.dependsOnTriggerid = dependsontriggerid;
        }


        /// <summary>
        /// ID of the dependent trigger.
        /// </summary>
        public string triggerid;

        /// <summary>
        /// ID of the trigger that the trigger depends on.
        /// </summary>
        public string dependsOnTriggerid;
    }
}