using Newtonsoft.Json;

namespace NetCoreOneSignalV7Client.Models
{
    public class OneSignalNotificationResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recipients")]
        public int Recipients { get; set; }

        [JsonProperty("external_id")]
        public object ExternalId { get; set; }

        [JsonProperty("errors")]
        public object Errors { get; set; }
    }
}