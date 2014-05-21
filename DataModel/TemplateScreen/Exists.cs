namespace ZabbixApi.DataModel.TemplateScreen
{
    public class Exists
    {
        /// <summary>
        /// Names of the screens.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the template screens must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the template screens must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// IDs of the screens.
        /// </summary>
        public string[] screenid;

        /// <summary>
        /// IDs of the templates that the screens belong to
        /// </summary>
        public string[] templateids;
    }
}