namespace ZabbixApi.DataModel.Action
{
    /// <summary>
    /// https://www.zabbix.com/documentation/2.4/manual/api/reference/action/object
    /// </summary>
    public class ActionCondition
    {
        /// <summary>
        /// </summary>
        /// <param name="conditiontype">Type of condition. 
        /// Possible values for trigger actions: 
        ///  0 - host group;
        ///  1 - host;
        ///  2 - trigger;
        ///  3 - trigger name;
        ///  4 - trigger severity;
        ///  5 - trigger value;
        ///  6 - time period;
        ///  13 - host template;
        ///  15 - application;
        ///  16 - maintenance status;
        ///  17 - node. 
        /// 
        /// Possible values for discovery actions:
        ///  7 - host IP;
        ///  8 - discovered service type;
        ///  9 - discovered service port;
        ///  10 - discovery status;
        ///  11 - uptime or downtime duration;
        ///  12 - received value; 
        ///  18 - discovery rule;
        ///  19 - discovery check;
        ///  20 - proxy;
        ///  21 - discovery object.
        /// Possible values for auto-registration actions:
        ///  20 - proxy; 22 - host name;
        ///  24 - host metadata.
        /// 
        /// Possible values for internal actions:
        ///  0 - host group;
        ///  1 - host;
        ///  13 - host template;
        ///  15 - application;
        ///  23 - event type;
        ///  17 - node.</param>
        /// <param name="value">Value to compare with.</param>
        public ActionCondition(int conditiontype, string value)
        {
            this.conditiontype = conditiontype;
            this.value = value;
        }

        /// <summary>
        ///  ID of the action condition.
        /// </summary>
        public string conditionid;

        /// <summary>
        /// Type of condition. 
        /// Possible values for trigger actions:
        ///  0 - host group;
        ///  1 - host; 
        ///  2 - trigger;
        ///  3 - trigger name;
        ///  4 - trigger severity;
        ///  5 - trigger value;
        ///  6 - time period;
        ///  13 - host template;
        ///  15 - application; 
        ///  16 - maintenance status;
        ///  17 - node.
        ///  Possible values for discovery actions:
        ///  7 - host IP;
        ///  8 - discovered service type;
        ///  9 - discovered service port;
        ///  10 - discovery status;
        ///  11 - uptime or downtime duration;
        ///  12 - received value;
        ///  18 - discovery rule;
        ///  19 - discovery check;
        ///  20 - proxy;
        ///  21 - discovery object.
        ///  Possible values for auto-registration actions:
        ///  20 - proxy;
        ///  22 - host name;
        ///  24 - host metadata.
        ///  Possible values for internal actions:
        ///  0 - host group;
        ///  1 - host;
        ///  13 - host template;
        ///  15 - application;
        ///  23 - event type;
        ///  17 - node.
        /// </summary>
        public int? conditiontype;

        /// <summary>
        /// Value to compare with.
        /// </summary>
        public string value;

        /// <summary>
        ///  ID of the action that the condition belongs to.
        /// </summary>
        public string actionid;

        /// <summary>
        /// Condition operator. Possible values: 0 - (default) =; 1 - <>; 2 - like; 3 - not like; 4 - in; 5 - >=; 6 - <=; 7 - not it.
        /// </summary>
        public int? @operator;
    }
}