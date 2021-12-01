using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class BillAction
    {
        [Obsolete("Not available from scrapers.")]
        [JsonPropertyName("organization")]
        public OrganizationRef Organization { get; set; }

        [JsonPropertyName("organization_id")]
        public string OrganizationId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("classification")]
        public ICollection<string> Classifications { get; set; } =
            new List<string>(); // referral-committee | introduction

        [Obsolete("Not available from scrapers. This may be implicit.")]
        [JsonPropertyName("order")]
        public int Order { get; set; }
    }
}