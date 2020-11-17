using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.GetOobConfirmationCode
{
    public class GetOobConfirmationCode : EndpointBase
    {
        public GetOobConfirmationCode(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:sendOobCode";
        }

        public async Task<bool> SendPasswordResetEmail(string email)
        {
            var requestBody = new
            {
                requestType = "PASSWORD_RESET",
                email = email
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody), locale: "jp");
            return true; // not implement
        }

        public async Task<bool> SendEmailVerification(string idToken)
        {
            var requestBody = new
            {
                requestType = "VERIFY_EMAIL",
                idToken = idToken
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody), locale: "jp");
            return true; // not implement
        }
    }
}
