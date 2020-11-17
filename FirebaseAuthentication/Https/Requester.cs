using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Https
{
    public class Requester
    {
        protected const string baseUrl = "https://identitytoolkit.googleapis.com/";
        private readonly HttpClient _httpClient;
        private string ApiKey { get; set; }

        public Requester(string key)
        {
            _httpClient = new HttpClient();
            ApiKey = key;
        }

        public async Task<string> CreatePostRequestAsync(string relativeUrl, string body,List<string> queryParameters = null, string locale = "")
        {
            var request = PrepareRequest(relativeUrl, queryParameters, HttpMethod.Post);
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");

            if (!string.IsNullOrEmpty(locale)) request.Headers.Add("X-Firebase-Locale", locale);

            using (var response = await SendAsync(request).ConfigureAwait(false))
            {
                return await GetResponseContentAsync(response).ConfigureAwait(false);
            }
        }

        public HttpRequestMessage PrepareRequest(string relativeUrl, List<string> queryParameters, HttpMethod httpMethod)
        {
                var url = queryParameters == null ?
                    $"{baseUrl}{relativeUrl}?key={ApiKey}" :
                    $"{baseUrl}{relativeUrl}?key={ApiKey}&{queryParameters.Where(arg => !string.IsNullOrWhiteSpace(arg)).Aggregate(string.Empty, (current, arg) => current + ("&" + arg))}";

                var requestMessage = new HttpRequestMessage(httpMethod, url);
                return requestMessage;
        }

        protected async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);
            return response;
        }

        protected async Task<string> GetResponseContentAsync(HttpResponseMessage response)
        {
            using (response)
            using (var content = response.Content)
            {
                return await content.ReadAsStringAsync().ConfigureAwait(false);
            }
        }
    }
}
