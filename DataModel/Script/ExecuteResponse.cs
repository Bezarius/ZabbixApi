namespace ZabbixApi.DataModel.Script
{
    public class ExecuteResponse
    {
        /// <summary>
        /// Whether the script was run successfully.
        /// Possible values:
        /// success or failed.
        /// </summary>
        public string response;

        /// <summary>
        /// Script output.
        /// </summary>
        public string value;
    }
}