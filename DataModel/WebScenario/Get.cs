using ZabbixApi.Common;

namespace ZabbixApi.DataModel.WebScenario
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only web scenarios that belong to the given applications.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        /// Return only web scenarios that belong to the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only web scenarios that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only web scenarios with the given IDs.
        /// </summary>
        public string[] httptestids;

        /// <summary>
        /// If set to true return only web scenarios inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// If set to true return only enabled web scenarios that belong to monitored hosts.
        /// </summary>
        public bool monitored;

        /// <summary>
        /// If set to true return only web scenarios that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// Return only web scenarios that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Expand macros in the name of the web scenario.
        /// </summary>
        public bool expandName;

        /// <summary>
        /// Expand macros in the names of scenario steps.
        /// </summary>
        public bool expandStepName;

        /// <summary>
        /// Return the host that the web scenario belongs to as an array in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return web scenario steps in the steps property.
        /// </summary>
        public string selectSteps;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// httptestid and name.
        /// </summary>
        public string[] sortfield;
    }
}