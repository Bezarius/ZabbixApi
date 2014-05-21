namespace ZabbixApi.DataModel.DiscoveryRule
{
    public class Update : DiscoveryRule
    {
        /// <summary>
        /// Discovery checks to create for the discovery rule
        /// </summary>
        public DiscoveryCheck.DiscoveryCheck[] dchecks;

        public Update(string iprange, string name)
            : base(iprange, name)
        {
        }
    }
}