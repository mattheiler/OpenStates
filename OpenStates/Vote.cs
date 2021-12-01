using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Vote
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }

        [JsonPropertyName("motion_text")]
        public string MotionText { get; set; }

        [JsonPropertyName("motion_classification")]
        public ICollection<string> MotionClassification { get; set; }

        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        [JsonPropertyName("result")]
        public string Result { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("organization")]
        public OrganizationRef Organization { get; set; }

        [JsonPropertyName("votes")]
        public ICollection<VotePosition> Positions { get; set; } = new List<VotePosition>();

        [JsonPropertyName("counts")]
        public ICollection<VoteCount> Counts { get; set; } = new List<VoteCount>();

        [JsonPropertyName("sources")]
        public ICollection<Source> Sources { get; set; } = new List<Source>();
    }
}