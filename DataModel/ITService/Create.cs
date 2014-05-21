namespace ZabbixApi.DataModel.ITService
{
    public class Create : ITService
    {
        /// <summary>
        /// </summary>
        /// <param name="algorithm">Algorithm used to calculate the state of the IT service. Possible values: 0 - do not calculate; 1 - problem, if at least one child has a problem; 2 - problem, if all children have problems.</param>
        /// <param name="name">Name of the IT service.</param>
        /// <param name="showsla">Whether SLA should be calculated. Possible values: 0 - do not calculate; 1 - calculate.</param>
        /// <param name="sortorder">Position of the IT service used for sorting.</param>
        public Create(int algorithm, string name, int showsla, int sortorder) : base(algorithm, name, showsla, sortorder)
        {
        }

        /// <summary>
        /// Service dependencies. Each service dependency has the following parameters: - dependsOnServiceid - (string) ID of an IT service the service depends on, that is, the child IT service. - soft - (integer) type of service dependency; refer to the service dependency object page for more information on dependency types.
        /// </summary>
        public string[] dependencies;

        /// <summary>
        /// ID of a hard-linked parent IT service.
        /// </summary>
        public string parentid;

        /// <summary>
        /// Service times to be created for the IT service.
        /// </summary>
        public string[] times;
    }
}