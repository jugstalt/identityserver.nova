using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.Token.ErrorHandling
{
    public class TokenVerificationException : Exception
    {
        public TokenVerificationException(string message) :
            base($"Token verification: { message }")
        {

        }
    }
}
