using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityServer.Legacy.DependencyInjection
{
    public interface IBuilder
    {
        IServiceCollection Services { get; }
    }
}
