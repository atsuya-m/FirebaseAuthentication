using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseAuthentication.Model
{
    public class SignUpWithEmailPasswordModel
    {
        public string idToken { get; set; }
        public string email { get; set; }
        public string refreshToken { get; set; }
        public string expiresIn { get; set; }
        public string localId { get; set; }
        public bool registered { get; set; }
    }
}
