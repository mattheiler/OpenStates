using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Jurisdiction
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonPropertyName("division_id")]
        public string DivisionId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("organizations")]
        public ICollection<Organization> Organizations { get; set; } = new List<Organization>();

        [JsonPropertyName("legislative_sessions")]
        public ICollection<LegislativeSession> LegislativeSessions { get; set; } = new List<LegislativeSession>();
    }
}