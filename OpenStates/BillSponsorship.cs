using System;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillSponsorship
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        [Obsolete("Not available from scrapers.")]
        [JsonPropertyName("organization")]
        public OrganizationRef Organization { get; set; }

        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        [Obsolete("Not available from scrapers.")]
        [JsonPropertyName("person")]
        public PersonRef Person { get; set; }

        [JsonPropertyName("person_id")]
        public string PersonId { get; set; }

        [JsonPropertyName("primary")]
        public bool IsPrimary { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; } // primary | cosponsor
    }
}