using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Source
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }
    }
}