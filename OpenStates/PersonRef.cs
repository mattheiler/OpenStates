using System.Text.Json.Serialization;

namespace OpenStates
{
    public class PersonRef
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("party")]
        public string Party { get; set; }

        [JsonPropertyName("current_role")]
        public Role CurrentRole { get; set; }
    }
}