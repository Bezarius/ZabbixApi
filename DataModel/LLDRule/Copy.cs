namespace ZabbixApi.DataModel.LLDRule
{
    public class Copy
    {
        /// <summary>
        /// IDs of the LLD rules to be copied.
        /// </summary>
        public string[] discoveryruleids;

        /// <summary>
        /// IDs of the hosts to copy the LLD rules to.
        /// </summary>
        public string[] hostids;
    }
}