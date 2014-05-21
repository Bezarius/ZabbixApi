namespace ZabbixApi.DataModel.Application
{
    public class Application
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the application belongs to. Cannot be updated.</param>
        /// <param name="name">Name of the application</param>
        public Application(string hostid, string name)
        {
            this.hostid = hostid;
            this.name = name;
        }

        /// <summary>
        ///  ID of the application.
        /// </summary>
        public string applicationid;

        /// <summary>
        /// ID of the host that the application belongs to. Cannot be updated.
        /// </summary>
        public string hostid;

        /// <summary>
        /// Name of the application
        /// </summary>
        public string name;

        /// <summary>
        ///  IDs of the parent template applications.
        /// </summary>
        public string[] templateids;
    }
}
