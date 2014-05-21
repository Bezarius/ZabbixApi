using ZabbixApi.Common;

namespace ZabbixApi.DataModel.UserMacro
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return global macros instead of host macros.
        /// </summary>
        public string globalmacro;

        /// <summary>
        /// Return only global macros with the given IDs.
        /// </summary>
        public string[] globalmacroids;

        /// <summary>
        /// Return only host macros that belong to hosts or templates from the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only host macros that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only host macros with the given IDs.
        /// </summary>
        public string[] hostmacroids;

        /// <summary>
        /// Return only host macros that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return host groups that the host macro belongs to in the groups property. Used only when retrieving host macros.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return hosts that the host macro belongs to in the hosts property. Used only when retrieving host macros.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return templates that the host macro belongs to in the templates property. Used only when retrieving host macros.
        /// </summary>
        public string selectTemplates;

        /// <summary>
        /// Sort the result by the given properties. Possible value: macro.
        /// </summary>
        public string[] sortfield;
    }
}