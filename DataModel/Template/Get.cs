using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Template
{
    public class Get : CommonGet
    {
        /// <summary>
        ///  Return only templates with the given template IDs.
        /// </summary>
        public int[] templateids;

        /// <summary>
        ///  Return only templates that belong to the given host groups.
        /// </summary>
        public int[] groupids;

        /// <summary>
        ///  Return only templates that are children of the given templates.
        /// </summary>
        public int[] parentTemplateids;

        /// <summary>
        ///  Return only templates that are linked to the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        ///  Return only templates that contain the given graphs.
        /// </summary>
        public int[] graphids;

        /// <summary>
        ///  Return only templates that contain the given items.
        /// </summary>
        public int[] itemids;

        /// <summary>
        ///  Return only templates that contain the given triggers.
        /// </summary>
        public int[] triggerids;

        /// <summary>
        ///  Return only templates that have items.
        /// </summary>
        public bool? with_items;

        /// <summary>
        ///  Return only templates that have triggers.
        /// </summary>
        public bool? with_triggers;

        /// <summary>
        ///  Return only templates that have graphs.
        /// </summary>
        public bool? with_graphs;

        /// <summary>
        ///  Return only templates that have web scenarios.
        /// </summary>
        public bool? with_httptests;

        /// <summary>
        ///  Return the host groups that the template belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        ///  Return the hosts that are linked to the template in the hosts property. Supports count.
        /// </summary>
        public string selectHosts;

        /// <summary>
        ///  Return the child templates in the templates property. Supports count.
        /// </summary>
        public string selectTemplates;

        /// <summary>
        ///  Return the parent templates in the parentTemplates property. Supports count.
        /// </summary>
        public string selectParentTemplates;

        /// <summary>
        /// Return the web scenarios from the template in the httpSteps property. Supports count.
        /// </summary>
        public string selectHttpTests;

        /// <summary>
        ///  Return items from the template in the items property. Supports count.
        /// </summary>
        public string selectItems;

        /// <summary>
        ///  Return low-level discoveries from the template in the discoveries property. Supports count.
        /// </summary>
        public string selectDiscoveries;

        /// <summary>
        ///  Return triggers from the template in the triggers property. Supports count.
        /// </summary>
        public string selectTriggers;

        /// <summary>
        ///  Return graphs from the template in the graphs property. Supports count.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        ///  Return applications from the template in the applications property. Supports count.
        /// </summary>
        public string selectApplications;

        /// <summary>
        ///  Return the macros from the template in the macros property..
        /// </summary>
        public string selectMacros;

        /// <summary>
        ///  Return screens from the template in the screens property. Supports count.
        /// </summary>
        public string selectScreens;

        /// <summary>
        /// Limits the number of records returned by subselects.
        /// Applies to the following subselects: 
        /// selectTemplates - results will be sorted by name;
        /// selectHosts - sorted by host; selectParentTemplates - sorted by host;
        /// selectItems - sorted by name;selectDiscoveries - sorted by name;
        /// selectTriggers - sorted by description;
        /// selectGraphs - sorted by name;
        /// selectApplications - sorted by name;
        /// selectScreens - sorted by name.
        /// </summary>
        public int? limitSelects;

        /// <summary>
        ///  Sort the result by the given properties.
        ///  Possible values are: hostid, host, name, status.
        /// </summary>
        public string[] sortfield;
    }
}
