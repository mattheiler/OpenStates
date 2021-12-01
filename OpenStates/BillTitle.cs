using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillTitle
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }
    }
}