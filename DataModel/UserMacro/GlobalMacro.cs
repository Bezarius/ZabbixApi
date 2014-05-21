namespace ZabbixApi.DataModel.UserMacro
{
    public class GlobalMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public GlobalMacro(string macro, string value)
        {
            this.macro = macro;
            this.value = value;
        }

        /// <summary>
        ///  ID of the global macro.
        /// </summary>
        public string globalmacroid;

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