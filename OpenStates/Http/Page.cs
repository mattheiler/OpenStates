using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates.Http
{
    public class Page<T>
    {
        [JsonPropertyName("results")]
        public IList<T> Results { get; set; } = new List<T>();

        [JsonPropertyName("pagination")]
        public PageInfo Info { get; set; }
    }
}