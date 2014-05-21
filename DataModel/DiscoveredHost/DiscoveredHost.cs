namespace ZabbixApi.DataModel.DiscoveredHost
{
    public class DiscoveredHost
    {
        //TODO: в документации небыло этого поля, но по всей видимости его пропустили, нужно проверить
        /// <summary>
        /// Discovered host services.
        /// </summary>
        public DiscoveredService.DiscoveredService[] dservices;

        /// <summary>
        /// ID of the discovered host.
        /// </summary>
        public string dhostid;

        /// <summary>
        /// ID of the discovery rule that detected the host.
        /// </summary>
        public string druleid;

        /// <summary>
        /// Time when the discovered host last went down.
        /// </summary>
        public long lastdown;

        /// <summary>
        /// Time when the discovered host last went up.
        /// </summary>
        public long lastup;

        /// <summary>
        /// Whether the discovered host is up or down. A host is up if it has at least one active discovered service.
        /// Possible values:
        /// 0 - host up;
        /// 1 - host down.
        /// </summary>
        public int status;
    }
}
