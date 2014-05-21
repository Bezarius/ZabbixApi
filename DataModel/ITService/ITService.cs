﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixApi.DataModel.ITService
{
    public class ITService
    {
        /// <summary>
        /// </summary>
        /// <param name="algorithm">Algorithm used to calculate the state of the IT service. Possible values: 0 - do not calculate; 1 - problem, if at least one child has a problem; 2 - problem, if all children have problems.</param>
        /// <param name="name">Name of the IT service.</param>
        /// <param name="showsla">Whether SLA should be calculated. Possible values: 0 - do not calculate; 1 - calculate.</param>
        /// <param name="sortorder">Position of the IT service used for sorting.</param>
        public ITService(int algorithm, string name, int showsla, int sortorder)
        {
            this.algorithm = algorithm;
            this.name = name;
            this.showsla = showsla;
            this.sortorder = sortorder;
        }


        /// <summary>
        ///  ID of the IT service.
        /// </summary>
        public string serviceid;

        /// <summary>
        /// Algorithm used to calculate the state of the IT service. Possible values: 0 - do not calculate; 1 - problem, if at least one child has a problem; 2 - problem, if all children have problems.
        /// </summary>
        public int algorithm;

        /// <summary>
        /// Name of the IT service.
        /// </summary>
        public string name;

        /// <summary>
        /// Whether SLA should be calculated. Possible values: 0 - do not calculate; 1 - calculate.
        /// </summary>
        public int showsla;

        /// <summary>
        /// Position of the IT service used for sorting.
        /// </summary>
        public int sortorder;

        /// <summary>
        /// Minimum acceptable SLA value. If the SLA drops lower, the IT service is considered to be in problem state. Default: 99.9.
        /// </summary>
        public string goodsla;

        /// <summary>
        ///  Whether the IT service is in OK or problem state. If the IT service is in problem state, status is equal either to: - the priority of the linked trigger if it is set to 2, “Warning” or higher (priorities 0, “Not classified” and 1, “Information” are ignored); - the highest status of a child IT service in problem state. If the IT service is in OK state, status is equal to 0.
        /// </summary>
        public int status;

        /// <summary>
        /// Trigger associated with the IT service. Can only be set for IT services that don't have children.
        /// </summary>
        public string triggerid;
    }
}
