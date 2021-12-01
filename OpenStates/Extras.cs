using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Extras
    {
        [JsonPropertyName("profession")]
        public string Profession { get; set; }
    }
}