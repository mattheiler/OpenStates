using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;

namespace OpenStates.Http
{
    public abstract class Request<T>
    {
        private readonly IFlurlClient _http;

        private readonly HashSet<string> _includes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        private readonly Dictionary<string, string> _params =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        private readonly SemaphoreSlim _requests;

        private readonly List<string> _segments = new List<string>();

        protected Request(IFlurlClient http, SemaphoreSlim requests)
        {
            _http = http;
            _requests = requests;
        }

        public virtual async Task<T> GetAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await _requests.WaitAsync(cancellationToken);

                while (true)
                {
                    try
                    {
                        var request = _http.Request().AppendPathSegments(_segments);
                        foreach (var (key, value) in _params)
                            request.SetQueryParam(key, value);
                        request.SetQueryParam("include", _includes);
                        var content = await request.GetStreamAsync(cancellationToken);
                        var data = await JsonSerializer.DeserializeAsync<T>(content, null, cancellationToken);
                        return data;
                    }
                    catch (FlurlHttpException e)
                    {
                        switch (e.StatusCode)
                        {
                            case (int) HttpStatusCode.TooManyRequests:
                                Console.WriteLine("Kaboom!");
                                await Task.Delay(TimeSpan.FromSeconds(30), cancellationToken);
                                break;
                        }
                    }
                }
            }
            finally
            {
                _requests.Release();
            }
        }

        public Request<T> Include(string field)
        {
            _includes.Add(field);
            return this;
        }

        protected Request<T> AddPathSegment(string segment)
        {
            _segments.Add(segment);
            return this;
        }

        protected Request<T> AddPathSegments(params string[] segments)
        {
            _segments.AddRange(segments);
            return this;
        }

        protected Request<T> AddPathSegments(params object[] segments)
        {
            _segments.AddRange(segments.Select(segment => segment.ToString()));
            return this;
        }

        protected Request<T> AddQueryParam(string key, object value)
        {
            _params[key] = value.ToString();
            return this;
        }
    }
}