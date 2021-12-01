using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Organization
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonPropertyName("districts")]
        public ICollection<District> Districts { get; set; } = new List<District>();
    }
}