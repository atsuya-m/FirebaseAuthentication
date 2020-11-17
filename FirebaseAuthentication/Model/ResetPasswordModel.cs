using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseAuthentication.Model
{
    public class ResetPasswordModel
    {
        public string email { get; set; }
        public string requestType { get; set; }
    }

}
