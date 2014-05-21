namespace ZabbixApi.DataModel.LLDRule
{
    public class Exists
    {
        /// <summary>
        /// </summary>
        /// <param name="key_">Keys of the LLD rules.</param>
        public Exists(string[] key_)
        {
            this.key_ = key_;
        }

        /// <summary>
        /// Keys of the LLD rules.
        /// </summary>
        public string[] key_;

        /// <summary>
        /// Names of the hosts that the LLD rules must belong to.
        /// </summary>
        public string[] host;

        /// <summary>
        /// IDs of the hosts that the LLD rules must belong to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        /// Name of the node the LLD rules must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the LLD rules must belong to.
        /// </summary>
        public string[] nodeids;
    }
}