using ZabbixApi.Common;
using ZabbixApi.DataModel.Event;

namespace ZabbixApi.DataProviders
{
    internal sealed class EventProvider : DataProvider
    {
        public EventProvider(ZabbixClient client) : base(client) { }

        public string[] Acknowlege(Acknowlege request)
        {
            var response = base.SendRequest<EventIds>("event.acknowlege", request);
            return response.eventids;
        }

        public Event[] Get(Get request)
        {
            var response = base.SendRequest<Event[]>("event.get", request);
            return response;
        }
    }
}