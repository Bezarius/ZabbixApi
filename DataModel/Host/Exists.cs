namespace ZabbixApi.DataModel.Host
{
    public class Exists
    {
        /// <summary>
        ///  Host IDs.
        /// </summary>
        public string[] hostid;

        /// <summary>
        ///  Technical names of the hosts.
        /// </summary>
        public string[] host;

        /// <summary>
        ///  Visible names of the hosts.
        /// </summary>
        public string[] name;

        /// <summary>
        ///  Name of the node the hosts must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  IDs of the node the hosts must belong to.
        /// </summary>
        public string[] nodeids;
    }
}