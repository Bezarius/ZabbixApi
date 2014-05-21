namespace ZabbixApi.DataModel.TemplateScreen
{
    public class Copy
    {
        /// <summary>
        /// </summary>
        /// <param name="screenIds">IDs of template screens to copy.</param>
        /// <param name="templateIds">IDs of templates to copy the screens to.</param>
        public Copy(string[] screenIds, string[] templateids)
        {
            this.screenIds = screenIds;
            this.templateIds = templateids;
        }

        /// <summary>
        /// IDs of template screens to copy.
        /// </summary>
        public string[] screenIds;

        /// <summary>
        /// IDs of templates to copy the screens to.
        /// </summary>
        public string[] templateIds;
    }
}