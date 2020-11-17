using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.CreateAuthUri
{
    public class CreateAuthUri : EndpointBase
    {
        public CreateAuthUri(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:createAuthUri";
        }

        public async Task<FetchProvidersModel> FetchProvidersForEmail(string identifier, string continueUri)
        {
            var requestBody = new
            {
                identifier = identifier,
                continueUri = continueUri
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<FetchProvidersModel>(json);
        }
    }
}
