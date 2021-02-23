using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Event.EventMetadata
{
    public class RasaEventMetadata
    {
        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }
    }
}
