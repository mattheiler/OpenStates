using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class PersonListByLocationRequest : PageRequest<Page<Person>>
    {
        public PersonListByLocationRequest(IFlurlClient http, SemaphoreSlim requests, int lat, int lng) : base(http,
            requests)
        {
            AddPathSegments("people.geo");
            AddQueryParam("lat", lat);
            AddQueryParam("lng", lng);
        }

        public PersonListByLocationRequest IncludeOtherNames()
        {
            Include("other_names");
            return this;
        }

        public PersonListByLocationRequest IncludeOtherIdentifiers()
        {
            Include("other_identifiers");
            return this;
        }

        public PersonListByLocationRequest IncludeLinks()
        {
            Include("links");
            return this;
        }

        public PersonListByLocationRequest IncludeSources()
        {
            Include("sources");
            return this;
        }

        public PersonListByLocationRequest IncludeOffices()
        {
            Include("offices");
            return this;
        }
    }
}