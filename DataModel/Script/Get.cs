using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Script
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only scripts that can be run on the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only scripts that can be run on the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only scripts with the given IDs.
        /// </summary>
        public string[] scriptids;

        /// <summary>
        /// Return only scripts that can be run by users in the given user groups.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Return host groups that the script can be run on in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return hosts that the script can be run on in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// scriptid and name.
        /// </summary>
        public string[] sortfield;
    }
}