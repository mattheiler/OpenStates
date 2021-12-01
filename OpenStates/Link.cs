using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Link
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
    }
}