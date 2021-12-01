using System.Text.Json.Serialization;

namespace OpenStates
{
    public class JurisdictionRef
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; }
    }
}