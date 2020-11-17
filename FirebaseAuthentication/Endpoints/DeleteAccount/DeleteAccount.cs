using FirebaseAuthentication.Https;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FirebaseAuthentication.Endpoints.DeleteAccount
{
    class DeleteAccount : EndpointBase
    {
        public DeleteAccount(Requester requester) : base(requester)
        {
            endpoint = "/v1/accounts:delete";
        }

        public async Task<bool> Delete(string idToken)
        {
            var requestBody = new
            {
                idToken = idToken
            };
            var json = await _requester.CreatePostRequestAsync(endpoint, JsonSerializer.Serialize(requestBody));
            return true; // not implement
        }
    }
}
