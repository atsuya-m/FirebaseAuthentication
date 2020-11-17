using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.SignupNewUser
{
    public class SignupNewUser : EndpointBase
    {
        public SignupNewUser(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:signUp";
        }

        public async Task<SignUpWithEmailPasswordModel> SignInAnnonymously()
        {
            var requestBody = new
            {
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<SignUpWithEmailPasswordModel>(json);
        }

        public async Task<SignUpWithEmailPasswordModel> SignUpWithEmailPassword(string email, string password, string displayName = "")
        {
            var requestBody = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<SignUpWithEmailPasswordModel>(json);
        }
    }
}
