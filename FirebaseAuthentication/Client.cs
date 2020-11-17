using FirebaseAuthentication.Endpoints.CreateAuthUri;
using FirebaseAuthentication.Endpoints.GetOobConfirmationCode;
using FirebaseAuthentication.Endpoints.ResetPassword;
using FirebaseAuthentication.Endpoints.SetAccountInfo;
using FirebaseAuthentication.Endpoints.SignupNewUser;
using FirebaseAuthentication.Endpoints.VerifyPassword;
using FirebaseAuthentication.Https;

namespace FirebaseAuthentication
{
    public class Client
    {
        public CreateAuthUri CreateAuthUri { get; set; }
        public GetOobConfirmationCode GetOobConfirmationCode { get; set; }
        public ResetPassword ResetPassword { get; set; }
        public SetAccountInfo SetAccountInfo { get; set; }
        public SignupNewUser SignupNewUser { get; set; }
        public VerifyPassword VerifyPassword { get; set; }

        public Client(string key)
        {
            var requester = new Requester(key);
            CreateAuthUri = new CreateAuthUri(requester);
            GetOobConfirmationCode = new GetOobConfirmationCode(requester);
            ResetPassword = new ResetPassword(requester);
            SetAccountInfo = new SetAccountInfo(requester);
            SignupNewUser = new SignupNewUser(requester);
            VerifyPassword = new VerifyPassword(requester);
        }
    }
}
