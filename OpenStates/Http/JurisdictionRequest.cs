using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public class JurisdictionRequest : Request<Jurisdiction>
    {
        public JurisdictionRequest(IFlurlClient http, SemaphoreSlim requests, string id) : base(http, requests)
        {
            AddPathSegments("jurisdictions", id);
        }

        public JurisdictionRequest IncludeOrganizations()
        {
            Include("organizations");
            return this;
        }

        public JurisdictionRequest IncludeLegislativeSessions()
        {
            Include("legislative_sessions");
            return this;
        }
    }
}