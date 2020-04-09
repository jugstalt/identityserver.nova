using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer.Legacy.DbContext
{
    public interface IResourceDbContext
    {
        Task<ApiResource> FindApiResourceAsync(string name);
        Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames);

        Task AddApiResourceAsync(ApiResource apiResource);
        Task UpdateApiResourceAsync(ApiResource apiResource);
        Task RemoveApiResourceAsync(ApiResource apiResource);
    }
}
