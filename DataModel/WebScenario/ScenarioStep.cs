namespace ZabbixApi.DataModel.WebScenario
{
    public class ScenarioStep
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the scenario step.</param>
        /// <param name="no">Sequence number of the step in a web scenario.</param>
        /// <param name="url">URL to be checked.</param>
        public ScenarioStep(string name, int no, string url)
        {
            this.name = name;
            this.no = no;
            this.url = url;
        }
        
        /// <summary>
        ///  ID of the scenario step.
        /// </summary>
        public string httpstepid;

        /// <summary>
        /// Name of the scenario step.
        /// </summary>
        public string name;

        /// <summary>
        /// Sequence number of the step in a web scenario.
        /// </summary>
        public int no;

        /// <summary>
        /// URL to be checked.
        /// </summary>
        public string url;

        /// <summary>
        ///  ID of the web scenario that the step belongs to.
        /// </summary>
        public string httptestid;

        /// <summary>
        /// HTTP POST variables as a string.
        /// </summary>
        public string posts;

        /// <summary>
        /// Text that must be present in the response.
        /// </summary>
        public string required;

        /// <summary>
        /// Ranges of required HTTP status codes separated by commas.
        /// </summary>
        public string status_codes;

        /// <summary>
        /// Request timeout in seconds.
        /// Default: 15.
        /// </summary>
        public int timeout;

        /// <summary>
        /// Scenario step variables.
        /// </summary>
        public string variables;
    }
}