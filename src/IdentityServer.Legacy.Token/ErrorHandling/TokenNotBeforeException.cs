using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.Token.ErrorHandling
{
    public class TokenNotBeforeException : TokenVerificationException 
    {
        public TokenNotBeforeException()
            : base("Not use before")
        {

        }
    }
}
