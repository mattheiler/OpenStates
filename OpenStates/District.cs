using System.Text.Json.Serialization;

namespace OpenStates
{
    public class District
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }

        [JsonPropertyName("division_id")]
        public string DivisionId { get; set; }

        [JsonPropertyName("maximum_memberships")]
        public int MaximumMemberships { get; set; }
    }
}