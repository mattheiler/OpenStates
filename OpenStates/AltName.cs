using System.Text.Json.Serialization;

namespace OpenStates
{
    public class AltName
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }
    }
}