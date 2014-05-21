namespace ZabbixApi.DataModel.HostPrototype
{
    public class Update : HostPrototype
    {
        /// <summary>
        /// Group links to replace the current group links on the host prototype.
        /// </summary>
        public GroupLink[] groupLinks;

        /// <summary>
        /// Group prototypes to replace the existing group prototypes on the host prototype.
        /// </summary>
        public GroupPrototype[] groupPrototypes;

        /// <summary>
        /// Host prototype inventory properties.
        /// </summary>
        public HostPrototypeInventory inventory;

        /// <summary>
        /// Templates to replace the currently linked templates. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;

        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the host prototype.</param>
        public Update(string host) : base(host)
        {
        }
    }
}