namespace ZabbixApi.DataModel.Event
{
    public class Acknowlege
    {
        /// <summary>
        /// </summary>
        /// <param name="eventids">IDs of the events to acknowledge.</param>
        public Acknowlege(string eventids)
        {
            this.eventids = eventids;
        }


        /// <summary>
        /// IDs of the events to acknowledge.
        /// </summary>
        public string eventids;

        /// <summary>
        /// Text of the acknowledgement message
        /// </summary>
        public string message;
    }

    public class EventIds
    {
        public string[] eventids;
    }
}