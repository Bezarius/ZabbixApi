namespace ZabbixApi.DataModel.Screen
{
    public class Exists
    {
        /// <summary>
        /// Names of the screens.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the screens must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the screens must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// IDs of the screens.
        /// </summary>
        public string[] screenid;
    }
}