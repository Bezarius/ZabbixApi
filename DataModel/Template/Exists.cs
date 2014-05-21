namespace ZabbixApi.DataModel.Template
{
    public class Exists
    {
        /// <summary>
        ///  Technical names of the templates.
        /// </summary>
        public string[] host;

        /// <summary>
        ///  Visible names of the templates.
        /// </summary>
        public string[] name;

        /// <summary>
        ///  Name of the node the templates must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  IDs of the node the hosts must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        ///  Template IDs.
        /// </summary>
        public string[] templateid;
    }
}