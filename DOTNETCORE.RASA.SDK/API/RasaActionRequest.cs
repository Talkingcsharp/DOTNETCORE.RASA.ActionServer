using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.API
{
    public class RasaActionRequest
    {
        [JsonPropertyName("sender_id")]
        public string SenderId { get; set; }
        [JsonPropertyName("next_action")]
        public string NextAction { get; set; }
        [JsonPropertyName("tracker")]
        public RasaTracker Tracker { get; set; }
    }
}
