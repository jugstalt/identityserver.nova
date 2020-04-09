using IdentityServer.Legacy.Cryptography;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    public class UserDbContextConfiguration
    {
        public string ConnectionString { get; set; }
        public ICryptoService CryptoService { get; set; }
    }
}
