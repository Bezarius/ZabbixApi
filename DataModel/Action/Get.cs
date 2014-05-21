using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Action
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only actions with the given IDs.
        /// </summary>
        public string[] actionids;

        /// <summary>
        /// Return only actions that use the given host groups in action conditions.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only actions that use the given hosts in action conditions.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only actions that use the given triggers in action conditions.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return only actions that use the given media types to send messages.
        /// </summary>
        public string[] mediatypeids;

        /// <summary>
        /// Return only actions that are configured to send messages to the given user groups.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Return only actions that are configured to send messages to the given users.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// Return only actions that are configured to run the given scripts.
        /// </summary>
        public string[] scriptids;

        /// <summary>
        /// Return action conditions in the conditions property.
        /// </summary>
        public string selectConditions;

        /// <summary>
        /// Return action operations in the operations property.
        /// </summary>
        public string selectOperations;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// actionid, name and status.
        /// </summary>
        public string[] sortfield;
    }
}