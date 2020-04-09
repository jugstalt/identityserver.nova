using IdentityModel;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy
{
    public class Sha256PasswordHasher : PasswordHasher
    {
        override public string HashPassword(ApplicationUser user, string password)
        {
            return password.ToSha256();
        }
    }
}
