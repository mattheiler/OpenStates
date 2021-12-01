using System.Text.Json.Serialization;

namespace OpenStates.Http
{
    public class PageInfo
    {
        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("max_page")]
        public int MaxPage { get; set; }

        [JsonPropertyName("total_items")]
        public int TotalItems { get; set; }
    }
}