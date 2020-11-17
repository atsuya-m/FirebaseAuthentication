using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.VerifyPassword
{
    public class VerifyPassword : EndpointBase
    {
        public VerifyPassword(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:signInWithPassword";
        }

        public async Task<SignUpWithEmailPasswordModel> SignInWithEmailPassword(string email, string password, string displayName = "")
        {
            var requestBody = new {
                email = email,
                password = password,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<SignUpWithEmailPasswordModel>(json);
        }
    }
}
