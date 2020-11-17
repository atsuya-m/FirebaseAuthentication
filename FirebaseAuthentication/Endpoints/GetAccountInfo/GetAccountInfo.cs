using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FirebaseAuthentication.Endpoints.GetAccountInfo
{
    public class GetAccountInfo : EndpointBase
    {
        public  GetAccountInfo(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:lookup";
        }

        public async Task<List<User>> GetUserData(string idToken)
        {
            var requestBody = new
            {
                idToken = idToken
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<List<User>>(json);
        }
    }
}
