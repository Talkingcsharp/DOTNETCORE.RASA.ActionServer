using DOTNETCORE.RASA.SDK.RasaCore.Entity;
using DOTNETCORE.RASA.SDK.RasaCore.Intent;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Message
{
    public class RasaMessage
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }
        [JsonPropertyName("intent")]
        public RasaIntent Intent { get; set; }
        [JsonPropertyName("intent_ranking")]
        public RasaIntent[] IntentRanking { get; set; }
        [JsonPropertyName("entities")]
        public RasaEntity[]  Entities { get; set; }
    }
}
