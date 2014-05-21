namespace ZabbixApi.DataModel.Action
{
    public class Exists
    {
        /// <summary>
        /// IDs of actions.
        /// </summary>
        public string[] actionid;

        /// <summary>
        /// Names of actions.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the actions must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the actions must belong to.
        /// </summary>
        public string[] nodeids;
    }
}