using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    class ClientDbContextBuilder : Builder, IClientDbContextBuilder
    {
        public ClientDbContextBuilder(IServiceCollection services)
            : base(services)
        {

        }
    }
}
