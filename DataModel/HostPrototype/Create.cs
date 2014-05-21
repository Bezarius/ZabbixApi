namespace ZabbixApi.DataModel.HostPrototype
{
    public class Create
    {
        /// <summary>
        /// </summary>
        /// <param name="groupLinks">Group links to be created for the host prototype.</param>
        /// <param name="ruleid">ID of the LLD rule that the host prototype belongs to.</param>
        public Create(GroupLink[] groupLinks, string ruleid)
        {
            this.groupLinks = groupLinks;
            this.ruleid = ruleid;
        }

        /// <summary>
        /// Group links to be created for the host prototype.
        /// </summary>
        public GroupLink[] groupLinks;

        /// <summary>
        /// ID of the LLD rule that the host prototype belongs to.
        /// </summary>
        public string ruleid;

        /// <summary>
        /// Group prototypes to be created for the host prototype.
        /// </summary>
        public GroupPrototype[] groupPrototypes;

        /// <summary>
        /// Host prototype inventory properties.
        /// </summary>
        public HostPrototypeInventory inventory;

        /// <summary>
        /// Templates to be linked to the host prototype. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;
    }
}