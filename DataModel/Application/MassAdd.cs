using System.Collections.Generic;
using ZabbixApi.DataModel.Common;

namespace ZabbixApi.DataModel.Application
{
    public class MassAdd
    {
        /// <summary>
        /// </summary>
        /// <param name="applications">Applications to be updated. The applications must have the applicationid property defined.</param>
        public MassAdd(Application[] applications)
        {
            this.applications = applications;
        }


        /// <summary>
        /// Applications to be updated. The applications must have the applicationid property defined.
        /// </summary>
        public Application[] applications;

        /// <summary>
        /// Items to add to the given applications. The items must have the itemid property defined.
        /// </summary>
        public List<ItemId> items;
    }
}