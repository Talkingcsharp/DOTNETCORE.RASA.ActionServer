using DOTNETCORE.RASA.SDK.RasaCore.Event.EventParseData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Event
{
    public class RasaEvent
    {
        [JsonPropertyName("event")]
        public string Event { get; set; }
        [JsonPropertyName("timestamp")]
        public decimal TimeStamp { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("policy")]
        public string Ploicy { get; set; }
        [JsonPropertyName("confidence")]
        public decimal Confidence { get; set; }
        [JsonPropertyName("parse_data")]
        public RasaEventParseData ParseData { get; set; }
        [JsonPropertyName("input_channel")]
        public string InputChannel { get; set; }
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
        public RasaEventMetadata Metadata { get; set; }

    }
}
