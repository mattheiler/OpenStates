using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class JurisdictionListRequest : PageRequest<Jurisdiction>
    {
        public JurisdictionListRequest(IFlurlClient http, SemaphoreSlim requests) : base(http, requests)
        {
            AddPathSegment("jurisdictions");
        }

        public JurisdictionListRequest Classification(int value)
        {
            AddQueryParam("classification", value);
            return this;
        }

        public JurisdictionListRequest IncludeOrganizations()
        {
            Include("organizations");
            return this;
        }

        public JurisdictionListRequest IncludeLegislativeSessions()
        {
            Include("legislative_sessions");
            return this;
        }
    }
}