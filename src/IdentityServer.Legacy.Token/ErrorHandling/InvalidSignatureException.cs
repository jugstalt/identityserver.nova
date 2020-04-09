using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.Token.ErrorHandling
{
    public class InvalidSignatureException : TokenVerificationException
    {
        public InvalidSignatureException()
            : base("Invalid jwt signature")
        {

        }
    }
}
