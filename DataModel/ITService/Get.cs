using ZabbixApi.Common;

namespace ZabbixApi.DataModel.ITService
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only IT services with the given IDs.
        /// </summary>
        public string[] serviceids;

        /// <summary>
        /// Return only IT services with the given hard-dependent parent IT services.
        /// </summary>
        public string[] parentids;

        /// <summary>
        /// Return only IT services that are hard-dependent on the given child IT services.
        /// </summary>
        public string[] childids;

        /// <summary>
        /// Return the hard-dependent parent IT service in the parent property.
        /// </summary>
        public string selectParent;

        /// <summary>
        /// Return child service dependencies in the dependencies property.
        /// </summary>
        public string selectDependencies;

        /// <summary>
        /// Return parent service dependencies in the parentDependencies property.
        /// </summary>
        public string selectParentDependencies;

        /// <summary>
        /// Return service times in the times property.
        /// </summary>
        public string selectTimes;

        /// <summary>
        /// Return service alarms in the alarms property.
        /// </summary>
        public string selectAlarms;

        /// <summary>
        /// Return the associated trigger in the trigger property.
        /// </summary>
        public string selectTrigger;

        /// <summary>
        /// Sort the result by the given properties. Possible values are: name and sortorder.
        /// </summary>
        public string[] sortfield;
    }
}