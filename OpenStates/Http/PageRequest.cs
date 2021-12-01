using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Flurl.Http;

namespace OpenStates.Http
{
    public abstract class PageRequest<T> : Request<Page<T>>
    {
        protected PageRequest(IFlurlClient http, SemaphoreSlim requests) : base(http, requests)
        {
        }


        public PageRequest<T> Page(int value)
        {
            AddQueryParam("page", value);
            return this;
        }

        public PageRequest<T> PerPage(int value)
        {
            AddQueryParam("per_page", value);
            return this;
        }

        public async IAsyncEnumerable<T> GetAllAsync(
            [EnumeratorCancellation] CancellationToken cancellationToken = default)
        {
            var page = 1;
            int pages;

            do
            {
                var response = await Page(page).GetAsync(cancellationToken);

                foreach (var result in response.Results) yield return result;

                pages = response.Info.MaxPage;
            } while (page++ < pages);
        }
    }
}