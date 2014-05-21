using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Application
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only applications with the given IDs.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        /// Return only applications that belong to hosts from the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only applications that belong to the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// If set to true return only applications inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Return only applications that contain the given items.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// If set to true return only applications that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// Return only applications that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return the name of the host that the application belongs to as a property of the application object.
        /// </summary>
        public string expandData;

        /// <summary>
        /// Return the hosts that the application belongs to in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return the items contained in the application in the items property.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// applicationid and name.
        /// </summary>
        public string[] sortfield;
    }
}