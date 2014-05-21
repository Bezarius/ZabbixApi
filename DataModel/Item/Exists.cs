namespace ZabbixApi.DataModel.Item
{
    public class Exists
    {
        /// <summary>
        /// </summary>
        /// <param name="key_">Keys of the items.</param>
        public Exists(string[] key_)
        {
            this.key_ = key_;
        }


        /// <summary>
        /// Keys of the items.
        /// </summary>
        public string[] key_;

        /// <summary>
        /// Names of the hosts that the items must belong to.
        /// </summary>
        public string[] host;

        /// <summary>
        /// IDs of the hosts that the items must belong to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        /// Name of the node the items must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the items must belong to.
        /// </summary>
        public string[] nodeids;
    }
}