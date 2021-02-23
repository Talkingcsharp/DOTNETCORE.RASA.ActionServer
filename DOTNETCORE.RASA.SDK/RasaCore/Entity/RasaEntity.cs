using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Entity
{
    public class RasaEntity
    {
        [JsonPropertyName("entity")]
        public string Entity { get; set; }
        [JsonPropertyName("start")]
        public int Start { get; set; }
        [JsonPropertyName("end")]
        public int End { get; set; }
        [JsonPropertyName("confidence_entity")]
        public decimal Confidence { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("extractor")]
        public string Extractor { get; set; }
    }
}
