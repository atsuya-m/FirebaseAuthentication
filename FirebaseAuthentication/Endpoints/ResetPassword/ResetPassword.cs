using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.ResetPassword
{
    public class ResetPassword : EndpointBase
    {
        public ResetPassword(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:update";
        }

        public async Task<ResetPasswordModel> ConfirmPasswordReset(string oobCode, string newPassword)
        {
            var requestBody = new {
                oobCode = oobCode,
                newPassword = newPassword
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<ResetPasswordModel>(json);
        }

        public async Task<ResetPasswordModel> VerifyPasswordResetCode(string oobCode)
        {
            var requestBody = new
            {
                oobCode = oobCode
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<ResetPasswordModel>(json);
        }
    }
}
                                                    