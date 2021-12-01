using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillAbstract
    {
        [JsonPropertyName("abstract")]
        public string Abstract { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }
    }
}