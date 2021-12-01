using System.Text.Json.Serialization;

namespace OpenStates
{
    public class AltIdentifier
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("scheme")]
        public string Scheme { get; set; }
    }
}