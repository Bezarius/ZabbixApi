﻿namespace ZabbixApi.DataModel.UserGroup
{
    public class Create : UserGroup
    {
        /// <summary>
        /// Permissions to assign to the group
        /// </summary>
        public Permission[] rights;

        /// <summary>
        /// IDs of users to add to the user group.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// </summary>
        /// <param name="name">Name of the user group.</param>
        public Create(string name)
            : base(name)
        {
        }
    }
}