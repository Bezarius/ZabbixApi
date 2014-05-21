namespace ZabbixApi.DataModel.WebScenario
{
    public class Create : WebScenario
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the web scenario belongs to.</param>
        /// <param name="name">Name of the web scenario.</param>
        public Create(string hostid, string name, ScenarioStep[] steps)
            : base(hostid, name)
        {
            this.steps = steps;
        }

        /// <summary>
        /// Web scenario steps.
        /// </summary>
        public ScenarioStep[] steps;
    }
}