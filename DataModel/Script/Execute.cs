namespace ZabbixApi.DataModel.Script
{
    public class Execute
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host to run the script on.</param>
        /// <param name="scriptid">ID of the script to run.</param>
        public Execute(string hostid, string scriptid)
        {
            this.hostid = hostid;
            this.scriptid = scriptid;
        }
        
        /// <summary>
        /// ID of the host to run the script on.
        /// </summary>
        public string hostid;

        /// <summary>
        /// ID of the script to run.
        /// </summary>
        public string scriptid;
    }
}