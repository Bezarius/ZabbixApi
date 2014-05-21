using System;
using ZabbixApi.DataModel.Event;
using ZabbixApi.DataProviders;
using ZabbixApi.Helpers;

namespace ZabbixApi.Agents
{
    public class EventAgent
    {
        private readonly EventProvider _event;

        public EventAgent(ZabbixClient zabbixClient)
        {
            _event = new EventProvider(zabbixClient);
        }

        public Event[] GetAll()
        {
            var response = _event.Get(new Get
                {
                    output = "extend",
                    select_acknowledges = "extend"
                });
            return response;
        }

        public Event[] GetLastEventForPeriod(TimeSpan span, TypeOfEvent typeOfEvent = TypeOfEvent.Trigger, TypeOfObjectRelatedEvent relatedEvent = TypeOfObjectRelatedEvent.Trigger)
        {
            return GetInRange((DateTime.UtcNow - span), DateTime.UtcNow, null, typeOfEvent, relatedEvent);
        }

        public Event[] GetLastEventForPeriodByHostId(TimeSpan span, int hostid, TypeOfEvent typeOfEvent = TypeOfEvent.Trigger, TypeOfObjectRelatedEvent relatedEvent = TypeOfObjectRelatedEvent.Trigger)
        {
            return GetInRange((DateTime.UtcNow - span), DateTime.UtcNow, new[] { hostid }, typeOfEvent, relatedEvent);
        }

        public Event[] GetLastEventForPeriodByHostIds(TimeSpan span, int[]hostids, TypeOfEvent typeOfEvent = TypeOfEvent.Trigger, TypeOfObjectRelatedEvent relatedEvent = TypeOfObjectRelatedEvent.Trigger)
        {
            return GetInRange((DateTime.UtcNow - span), DateTime.UtcNow, hostids, typeOfEvent, relatedEvent);
        }

        public Event[] GetInRange(DateTime from, DateTime to, int[] hostids, TypeOfEvent typeOfEvent = TypeOfEvent.Trigger, TypeOfObjectRelatedEvent relatedEvent = TypeOfObjectRelatedEvent.Trigger)
        {
            if (from == null || to == null)
                throw new ArgumentNullException();

            var response = _event.Get(new Get
            {
                time_from = from.ToUnixTime(),
                time_till = to.ToUnixTime(),
                @object = relatedEvent,
                source = typeOfEvent,
                sortfield = new []{"eventid"},
                output = "extend",
                sortorder = new[] { "desc" }
            });
            return response;
        }

        public Event[] GetNLastEventsBySourceId(int count, int sourceId, TypeOfEvent typeOfEvent = TypeOfEvent.Trigger, TypeOfObjectRelatedEvent relatedEvent = TypeOfObjectRelatedEvent.Trigger)
        {
            var response = _event.Get(new Get
            {
                objectids = new[]{sourceId},
                /*
                @object = relatedEvent,
                source = typeOfEvent,
                sortfield = new[] { "clock" },
                sortorder = new[] { "desc" },*/
                //limit = count
            });
            return response;
        }
    }
}