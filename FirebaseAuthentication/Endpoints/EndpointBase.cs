using FirebaseAuthentication.Https;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirebaseAuthentication.Endpoints
{
    public class EndpointBase
    {
        internal readonly Requester _requester;
        internal string endpoint { get; set; } = "";
        public EndpointBase(Requester requester)
        {
            _requester = requester;
        }
    }
}
