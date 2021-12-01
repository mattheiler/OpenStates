using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Role
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("org_classification")]
        public string OrgClassification { get; set; }

        [JsonPropertyName("district")]
        public string District { get; set; }

        [JsonPropertyName("division_id")]
        public string DivisionId { get; set; }
    }
}