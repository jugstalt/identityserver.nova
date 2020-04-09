using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    class Builder : IBuilder
    {
        public Builder(IServiceCollection services)
        {
            this.Services = services;
        }

        public IServiceCollection Services { get; private set; }
    }
}
