﻿namespace IdentityServer.Nova.Token.ErrorHandling;

public class TokenNotBeforeException : TokenValidationException
{
    public TokenNotBeforeException()
        : base("Not use before")
    {

    }
}
