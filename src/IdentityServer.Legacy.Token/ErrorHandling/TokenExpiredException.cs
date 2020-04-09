using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.Token.ErrorHandling
{
    public class TokenExpiredException : TokenVerificationException
    {
        public TokenExpiredException() 
            : base("token expired")
        {

        }
    }
}
