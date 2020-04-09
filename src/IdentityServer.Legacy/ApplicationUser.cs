using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityServer.Legacy
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            // Test
            //Claims = new Claim[]
            //    {
            //        new Claim(JwtClaimTypes.Name, "Alice Smith"),
            //        new Claim(JwtClaimTypes.GivenName, "Alice"),
            //        new Claim(JwtClaimTypes.FamilyName, "Smith"),
            //        new Claim(JwtClaimTypes.Email, "AliceSmith@email.com"),
            //        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
            //        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
            //        new Claim(JwtClaimTypes.Role, "rol1,role2"),
            //        new Claim(JwtClaimTypes.Address, @"{ 'street_address': 'One Hacker Way', 'locality': 'Heidelberg', 'postal_code': 69118, 'country': 'Germany' }", ClaimValueTypes.String)
            //    };
        }

        public bool IsLocked { get; set; }

        #region Claims

        private ICollection<Claim> _claims = null;

        [JsonIgnore]
        public ICollection<Claim> Claims
        {
            get
            {
                if (this._claims == null)
                    return new Claim[0];

                return this._claims;
            }

            set
            {
                _claims = value;
            }
        }

        #endregion

        #region TFA

        public string AuthenticatorKey { get; set; }
        public IEnumerable<string> TfaRecoveryCodes { get; set; }

        #endregion
    }
}
