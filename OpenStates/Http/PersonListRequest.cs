using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class PersonListRequest : PageRequest<Person>
    {
        public PersonListRequest(IFlurlClient http, SemaphoreSlim requests) : base(http, requests)
        {
            AddPathSegments("people");
        }

        public PersonListRequest Jurisdiction(string value)
        {
            AddQueryParam("jurisdiction", value);
            return this;
        }

        public PersonListRequest Name(string value)
        {
            AddQueryParam("name", value);
            return this;
        }

        public PersonListRequest Id(string value)
        {
            AddQueryParam("id", value);
            return this;
        }

        public PersonListRequest OrgClassification(string value)
        {
            AddQueryParam("org_classification", value);
            return this;
        }

        public PersonListRequest IncludeOtherNames()
        {
            Include("other_names");
            return this;
        }

        public PersonListRequest IncludeOtherIdentifiers()
        {
            Include("other_identifiers");
            return this;
        }

        public PersonListRequest IncludeLinks()
        {
            Include("links");
            return this;
        }

        public PersonListRequest IncludeSources()
        {
            Include("sources");
            return this;
        }

        public PersonListRequest IncludeOffices()
        {
            Include("offices");
            return this;
        }
    }
}