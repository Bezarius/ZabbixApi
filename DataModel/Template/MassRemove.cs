namespace ZabbixApi.DataModel.Template
{
    public class MassRemove
    {
        /// <summary>
        /// </summary>
        /// <param name="templateids">IDs of the templates to be updated.</param>
        public MassRemove(string[] templateids)
        {
            this.templateids = templateids;
        }

        /// <summary>
        /// IDs of the templates to be updated.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Host groups to remove the given templates from.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Hosts or templates to unlink the given templates from.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// User macros to delete from the given templates.
        /// </summary>
        public string[] macros;

        /// <summary>
        /// Templates to unlink and clear from the given templates.
        /// </summary>
        public string[] templateids_clear;

        /// <summary>
        /// Templates to unlink from the given templates.
        /// </summary>
        public string[] templateids_link;
    }
}