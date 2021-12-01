using System;
using System.Threading;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace OpenStates.Http
{
    public class OpenStatesApiClient
    {
        private readonly IFlurlClient _http;

        private readonly SemaphoreSlim _requests = new SemaphoreSlim(1, 1);

        public OpenStatesApiClient(IFlurlClient http)
        {
            _http = http;
        }

        public OpenStatesApiClient(IFlurlClientFactory http, string key)
            : this(http.Get("https://v3.openstates.org/").WithHeader("X-API-KEY", key))
        {
        }

        public JurisdictionListRequest GetJurisdictions()
        {
            return new JurisdictionListRequest(_http, _requests);
        }

        public JurisdictionRequest GetJurisdiction(string id)
        {
            return new JurisdictionRequest(_http, _requests, id);
        }

        public PersonListRequest GetPeople()
        {
            return new PersonListRequest(_http, _requests);
        }

        public PersonListByLocationRequest GetPeopleByLocation(int lat, int lng)
        {
            return new PersonListByLocationRequest(_http, _requests, lat, lng);
        }

        public BillListRequest GetBills()
        {
            return new BillListRequest(_http, _requests);
        }

        public BillRequest GetBill(Guid id)
        {
            return new BillRequest(_http, _requests, id);
        }

        public BillByIdRequest GetBill(string jurisdiction, string session, string id)
        {
            return new BillByIdRequest(_http, _requests, jurisdiction, session, id);
        }
    }
}