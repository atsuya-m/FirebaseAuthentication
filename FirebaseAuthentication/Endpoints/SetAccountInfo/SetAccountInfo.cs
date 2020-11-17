using FirebaseAuthentication.Https;
using FirebaseAuthentication.Model;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.SetAccountInfo
{
    public class SetAccountInfo : EndpointBase
    {
        public SetAccountInfo(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:update";
        }

        public async Task<User> ChangeEmail(string idToken, string newEmail)
        {
            var requestBody = new
            {
                idToken = idToken,
                email = newEmail,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody), locale: "jp");
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> ChangePassword(string idToken, string newPassword)
        {
            var requestBody = new
            {
                idToken = idToken,
                password = newPassword,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> UpdateProfile(string idToken, string displayName, string photoUrl)
        {
            var requestBody = new
            {
                idToken = idToken,
                displayName = displayName,
                photoUrl = photoUrl,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> LinkWithEmailPassword(string idToken, string newEmail, string newPassword)
        {
            var requestBody = new
            {
                idToken = idToken,
                email = newEmail,
                password = newPassword,
                returnSecureToken = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> LinkWithOAuthCredential(string idToken, string requestUri, string postBody)
        {
            var requestBody = new
            {
                idToken = idToken,
                requestUri = requestUri,
                postBody = postBody,
                returnSecureToken = true,
                returnIdpCredential = true
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> UnlinkProvider(string idToken, List<string> deleteProvider)
        {
            var requestBody = new
            {
                idToken = idToken,
                deleteProvider = deleteProvider
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }

        public async Task<User> ConfirmEmailVerification(string oobCode)
        {
            var requestBody = new
            {
                oobCode = oobCode
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return JsonSerializer.Deserialize<User>(json);
        }
    }
}
