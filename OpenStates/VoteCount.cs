using System.Text.Json.Serialization;

namespace OpenStates
{
    public class VoteCount
    {
        [JsonPropertyName("option")]
        public string Option { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}