using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseAuthentication.Model
{
    public class User
    {
        public string localId { get; set; }
        public string email { get; set; }
        public bool emailVerified { get; set; }
        public string displayName { get; set; }
        public List<Provideruserinfo> providerUserInfo { get; set; }
        public string photoUrl { get; set; }
        public string passwordHash { get; set; }
        public float passwordUpdatedAt { get; set; }
        public string validSince { get; set; }
        public bool disabled { get; set; }
        public string lastLoginAt { get; set; }
        public string createdAt { get; set; }
        public bool customAuth { get; set; }
    }

    public class Provideruserinfo
    {
        public string providerId { get; set; }
        public string displayName { get; set; }
        public string photoUrl { get; set; }
        public string federatedId { get; set; }
        public string email { get; set; }
        public string rawId { get; set; }
        public string screenName { get; set; }
    }

}
