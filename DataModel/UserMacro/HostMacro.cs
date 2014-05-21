namespace ZabbixApi.DataModel.UserMacro
{
    public class HostMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the macro belongs to.</param>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public HostMacro(string hostid, string macro, string value)
        {
            this.hostid = hostid;
            this.macro = macro;
            this.value = value;
        }


        /// <summary>
        ///  ID of the host macro.
        /// </summary>
        public string hostmacroid;

        /// <summary>
        /// ID of the host that the macro belongs to.
        /// </summary>
        public string hostid;

        /// <summary>
        /// Macro string.
        /// </summary>
        public string macro;

        /// <summary>
        /// Value of the macro.
        /// </summary>
        public string value;
    }
}
