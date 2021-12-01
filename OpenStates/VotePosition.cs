using System;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class VotePosition
    {
        [JsonPropertyName("options")]
        public string Option { get; set; } // abstain | no | absent | yes | excused?

        [JsonPropertyName("voter_name")]
        public string VoterName { get; set; }

        [JsonPropertyName("voter_id")]
        public string VoterId { get; set; }

        [Obsolete("Not available from scrapers.")]
        [JsonPropertyName("id")]
        public PersonRef Voter { get; set; }
    }
}