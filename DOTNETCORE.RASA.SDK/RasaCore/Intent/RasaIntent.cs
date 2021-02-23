using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Intent
{
    public class RasaIntent
    {
        [JsonPropertyName("id")]
        public long IntentId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("confidence")]
        public decimal Confidence { get; set; }

    }
}
