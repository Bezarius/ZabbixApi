namespace ZabbixApi.DataModel.Application
{
    public class Exists
    {
        /// <summary>
        /// IDs of the hosts the applications must belong to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        /// Names of the applications
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the applications must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// ID of the node the applications must belong to.
        /// </summary>
        public string[] nodeids;
    }
}