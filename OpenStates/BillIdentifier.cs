using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillIdentifier
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }
}