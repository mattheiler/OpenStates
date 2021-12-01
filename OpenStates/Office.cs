using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Office
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fax")]
        public string Fax { get; set; }

        [JsonPropertyName("voice")]
        public string Voice { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}