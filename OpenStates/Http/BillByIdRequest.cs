using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class BillByIdRequest : Request<Bill>
    {
        public BillByIdRequest(IFlurlClient http, SemaphoreSlim requests, string jurisdiction, string session,
            string id) : base(http, requests)
        {
            AddPathSegments("bills", jurisdiction, session, id);
        }

        public BillByIdRequest IncludeSponsorships()
        {
            Include("sponsorships");
            return this;
        }

        public BillByIdRequest IncludeAbstracts()
        {
            Include("abstracts");
            return this;
        }

        public BillByIdRequest IncludeOtherTitles()
        {
            Include("other_titles");
            return this;
        }

        public BillByIdRequest IncludeOtherIdentifiers()
        {
            Include("other_identifiers");
            return this;
        }

        public BillByIdRequest IncludeActions()
        {
            Include("actions");
            return this;
        }

        public BillByIdRequest IncludeSources()
        {
            Include("sources");
            return this;
        }

        public BillByIdRequest IncludeDocuments()
        {
            Include("documents");
            return this;
        }

        public BillByIdRequest IncludeVersions()
        {
            Include("versions");
            return this;
        }

        public BillByIdRequest IncludeVotes()
        {
            Include("votes");
            return this;
        }
    }
}