using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillDocument
    {
        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("links")]
        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}