using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenStates
{
    public class Bill
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("session")]
        public string Session { get; set; }

        [JsonPropertyName("jurisdiction")]
        public JurisdictionRef Jurisdiction { get; set; }

        [JsonPropertyName("from_organization")]
        public OrganizationRef FromOrganization { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("classification")]
        public ICollection<string> Classifications { get; set; } = new List<string>();

        [JsonPropertyName("subject")]
        public ICollection<string> Subjects { get; set; } = new List<string>();

        [JsonPropertyName("extras")]
        public Extras Extras { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonPropertyName("openstates_url")]
        public string OpenStatesUrl { get; set; }

        [JsonPropertyName("first_action_date")]
        public string FirstActionDate { get; set; }

        [JsonPropertyName("latest_action_date")]
        public string LatestActionDate { get; set; }

        [JsonPropertyName("latest_action_description")]
        public string LatestActionDescription { get; set; }

        [JsonPropertyName("latest_passage_date")]
        public string LatestPassageDate { get; set; }

        [JsonPropertyName("abstracts")]
        public ICollection<BillAbstract> Abstracts { get; set; } = new List<BillAbstract>();

        [JsonPropertyName("other_titles")]
        public ICollection<BillTitle> OtherTitles { get; set; } = new List<BillTitle>();

        [JsonPropertyName("other_identifiers")]
        public ICollection<BillIdentifier> OtherIdentifiers { get; set; } = new List<BillIdentifier>();

        [JsonPropertyName("sponsorships")]
        public ICollection<BillSponsorship> Sponsorships { get; set; } = new List<BillSponsorship>();

        [JsonPropertyName("actions")]
        public ICollection<BillAction> Actions { get; set; } = new List<BillAction>();

        [JsonPropertyName("sources")]
        public ICollection<Source> Sources { get; set; } = new List<Source>();

        [JsonPropertyName("versions")]
        public ICollection<BillDocument> Versions { get; set; } = new List<BillDocument>();

        [JsonPropertyName("documents")]
        public ICollection<BillDocument> Documents { get; set; } = new List<BillDocument>();

        [JsonPropertyName("votes")]
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}