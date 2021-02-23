using DOTNETCORE.RASA.SDK.RasaCore.Event;
using DOTNETCORE.RASA.SDK.RasaCore.Message;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace DOTNETCORE.RASA.SDK.RasaCore.Tracker
{
    public class RasaTracker
    {
        [JsonPropertyName("sender_id")]
        public string SenderId { get; set; }
        [JsonPropertyName("slots")]
        public Dictionary<string,string> Slots { get; set; }
        [JsonPropertyName("latest_message")]
        public RasaMessage LatestMessage { get; set; }
        [JsonPropertyName("latest_event_time")]
        public decimal LatestEventTime { get; set; }
        [JsonPropertyName("events")]
        public RasaEvent[] Events { get; set; }
        [JsonPropertyName("latest_input_channel")]
        public string LatestInputChannel { get; set; }
        [JsonPropertyName("active_loop")]
        public RasaActiveLoop   ActiveLoop{ get; set; }
        [JsonPropertyName("latest_action")]
        public RasaAction LatestAction { get; set; }
        [JsonPropertyName("latest_action_name")]
        public string LatestActionName { get; set; }
    }
}
