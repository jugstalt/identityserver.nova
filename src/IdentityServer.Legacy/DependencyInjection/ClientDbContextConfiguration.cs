using IdentityServer.Legacy.Cryptography;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    public class ClientDbContextConfiguration
    {
        public IEnumerable<Client> IntialClients { get; set; }

        public string ConnectionString { get; set; }
        public ICryptoService CryptoService { get; set; }
    }
}
