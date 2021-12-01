using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Person
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("party")]
        public string Party { get; set; }

        [JsonPropertyName("current_role")]
        public Role Role { get; set; }

        [JsonPropertyName("jurisdiction")]
        public JurisdictionRef Jurisdiction { get; set; }

        [JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        [JsonPropertyName("family_name")]
        public string FamilyName { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("birth_date")]
        public string BirthDate { get; set; }

        [JsonPropertyName("death_date")]
        public string DeathDate { get; set; }

        [JsonPropertyName("extras")]
        public Extras Extras { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("openstates_url")]
        public string OpenStatesUrl { get; set; }

        [JsonPropertyName("other_identifiers")]
        public ICollection<AltIdentifier> OtherIdentifiers { get; set; } = new List<AltIdentifier>();

        [JsonPropertyName("other_names")]
        public ICollection<AltName> OtherNames { get; set; } = new List<AltName>();

        [JsonPropertyName("links")]
        public ICollection<Link> Links { get; set; } = new List<Link>();

        [JsonPropertyName("sources")]
        public ICollection<Source> Sources { get; set; } = new List<Source>();

        [JsonPropertyName("offices")]
        public ICollection<Office> Offices { get; set; } = new List<Office>();
    }
}