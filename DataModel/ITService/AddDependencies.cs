namespace ZabbixApi.DataModel.ITService
{
    public class AddDependencies
    {
        /// <summary>
        /// ID of the IT service that depends on a service, that is, the parent service.
        /// </summary>
        public string serviceid;

        /// <summary>
        /// ID of the IT service that a service depends on, that is, the child service.
        /// </summary>
        public string dependsOnServiceid;

        /// <summary>
        /// Type of dependency. Refer to the service dependency object page for more information on dependency types.
        /// </summary>
        public string soft;
    }
}