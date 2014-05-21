namespace ZabbixApi.DataModel.User
{
    public class LoginResponse : User
    {
        /// <summary>
        /// </summary>
        /// <param name="alias">User alias.</param>
        public LoginResponse(string alias)
            : base(alias)
        {
        }

        /// <summary>
        /// Whether debug mode is enabled for the user.
        /// </summary>
        public bool debug_mode;

        /// <summary>
        /// User's authentication method to the frontend. Refer to the gui_access property of the user group object for a list of possible values.
        /// </summary>
        public int gui_access;

        /// <summary>
        /// Local node of the user.
        /// The object has the following properties:
        /// name - (string) Name of the node;
        /// nodeid - (string) ID of the node.
        /// </summary>
        public object node;

        /// <summary>
        /// Authentication token, which must be used in the following API requests.
        /// </summary>
        public string sessionid;

        /// <summary>
        /// IP address of the user.
        /// </summary>
        public string userip;
    }
}