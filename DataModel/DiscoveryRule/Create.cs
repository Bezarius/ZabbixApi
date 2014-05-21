namespace ZabbixApi.DataModel.DiscoveryRule
{
    public class Create : DiscoveryRule
    {
        /// <summary>
        /// Discovery checks to create for the discovery rule
        /// </summary>
        public DiscoveryCheck.DiscoveryCheck[] dchecks;

        public Create(string iprange, string name)
            : base(iprange, name)
        {
        }
    }
}