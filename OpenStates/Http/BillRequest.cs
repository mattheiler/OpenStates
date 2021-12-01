using System;
using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class BillRequest : Request<Bill>
    {
        public BillRequest(IFlurlClient http, SemaphoreSlim requests, Guid id) : base(http, requests)
        {
            AddPathSegments("bills", id);
        }

        public BillRequest IncludeSponsorships()
        {
            Include("sponsorships");
            return this;
        }

        public BillRequest IncludeAbstracts()
        {
            Include("abstracts");
            return this;
        }

        public BillRequest IncludeOtherTitles()
        {
            Include("other_titles");
            return this;
        }

        public BillRequest IncludeOtherIdentifiers()
        {
            Include("other_identifiers");
            return this;
        }

        public BillRequest IncludeActions()
        {
            Include("actions");
            return this;
        }

        public BillRequest IncludeSources()
        {
            Include("sources");
            return this;
        }

        public BillRequest IncludeDocuments()
        {
            Include("documents");
            return this;
        }

        public BillRequest IncludeVersions()
        {
            Include("versions");
            return this;
        }

        public BillRequest IncludeVotes()
        {
            Include("votes");
            return this;
        }
    }
}