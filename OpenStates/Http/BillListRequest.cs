using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class BillListRequest : PageRequest<Bill>
    {
        public BillListRequest(IFlurlClient http, SemaphoreSlim requests) : base(http, requests)
        {
            AddPathSegments("bills");
        }

        public BillListRequest Jurisdiction(string value)
        {
            AddQueryParam("jurisdiction", value);
            return this;
        }

        public BillListRequest Session(string value)
        {
            AddQueryParam("session", value);
            return this;
        }

        public BillListRequest Chamber(string value)
        {
            AddQueryParam("chamber", value);
            return this;
        }

        public BillListRequest Classification(string value)
        {
            AddQueryParam("classification", value);
            return this;
        }

        public BillListRequest Subject(string value)
        {
            AddQueryParam("subject", value);
            return this;
        }

        public BillListRequest UpdatedSince(string value)
        {
            AddQueryParam("updated_since", value);
            return this;
        }

        public BillListRequest CreatedSince(string value)
        {
            AddQueryParam("created_since", value);
            return this;
        }

        public BillListRequest ActionSince(string value)
        {
            AddQueryParam("action_since", value);
            return this;
        }

        public BillListRequest Sort(string value)
        {
            AddQueryParam("sort", value);
            return this;
        }

        public BillListRequest Sponsor(string value)
        {
            AddQueryParam("sponsor", value);
            return this;
        }

        public BillListRequest SponsorClassification(string value)
        {
            AddQueryParam("sponsor_classification", value);
            return this;
        }

        public BillListRequest Query(string value)
        {
            AddQueryParam("q", value);
            return this;
        }

        public BillListRequest IncludeSponsorships()
        {
            Include("sponsorships");
            return this;
        }

        public BillListRequest IncludeAbstracts()
        {
            Include("abstracts");
            return this;
        }

        public BillListRequest IncludeOtherTitles()
        {
            Include("other_titles");
            return this;
        }

        public BillListRequest IncludeOtherIdentifiers()
        {
            Include("other_identifiers");
            return this;
        }

        public BillListRequest IncludeActions()
        {
            Include("actions");
            return this;
        }

        public BillListRequest IncludeSources()
        {
            Include("sources");
            return this;
        }

        public BillListRequest IncludeDocuments()
        {
            Include("documents");
            return this;
        }

        public BillListRequest IncludeVersions()
        {
            Include("versions");
            return this;
        }

        public BillListRequest IncludeVotes()
        {
            Include("votes");
            return this;
        }
    }
}