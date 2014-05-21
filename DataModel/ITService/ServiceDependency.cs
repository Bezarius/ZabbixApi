namespace ZabbixApi.DataModel.ITService
{
    public class ServiceDependency
    {
        /// <summary>
        /// </summary>
        /// <param name="servicedownid">ID of the IT service, that a service depends on, that is, the child service. An IT service can have multiple children.</param>
        /// <param name="serviceupid">ID of the IT service, that is dependent on a service, that is, the parent service. An IT service can have multiple parents forming a directed graph.</param>
        /// <param name="soft">Type of dependency between IT services. Possible values: 0 - hard dependency; 1 - soft dependency. An IT service can have only one hard-dependent parent. This attribute has no effect on status or SLA calculation and is only used to create a core IT service tree. Additional parents can be added as soft dependencies forming a graph. An IT service can not be deleted if it has hard-dependent children.</param>
        public ServiceDependency(string servicedownid, string serviceupid, int soft)
        {
            this.servicedownid = servicedownid;
            this.serviceupid = serviceupid;
            this.soft = soft;
        }


        /// <summary>
        ///  ID of the service dependency.
        /// </summary>
        public string linkid;

        /// <summary>
        /// ID of the IT service, that a service depends on, that is, the child service. An IT service can have multiple children.
        /// </summary>
        public string servicedownid;

        /// <summary>
        /// ID of the IT service, that is dependent on a service, that is, the parent service. An IT service can have multiple parents forming a directed graph.
        /// </summary>
        public string serviceupid;

        /// <summary>
        /// Type of dependency between IT services. Possible values: 0 - hard dependency; 1 - soft dependency. An IT service can have only one hard-dependent parent. This attribute has no effect on status or SLA calculation and is only used to create a core IT service tree. Additional parents can be added as soft dependencies forming a graph. An IT service can not be deleted if it has hard-dependent children.
        /// </summary>
        public int soft;
    }
}