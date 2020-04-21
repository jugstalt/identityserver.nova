using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Legacy;
using IdentityServer.Legacy.Services.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer.Areas.Admin
{
    public class IndexModel : PageModel
    {
        public IndexModel(
            UserManager<ApplicationUser> userManager,
            IUserDbContext userDbContext = null, 
            IRoleDbContext roleDbContext = null, 
            IResourceDbContext resourceDbContxt = null,
            IClientDbContext clientDbContext = null)
        {
            _userManager = userManager;

            this.HasUserDb = userDbContext != null;
            this.HasRoleDb = roleDbContext != null;
            this.HasResourceDb = resourceDbContxt != null;
            this.HasClientDb = clientDbContext != null;
        }

        private UserManager<ApplicationUser> _userManager;

        public bool HasUserDb { get; private set; }
        public bool HasRoleDb { get; private set; }
        public bool HasResourceDb { get; private set; }
        public bool HasClientDb { get; private set; }

        public ApplicationUser ApplicationUser;

        async public Task OnGetAsync()
        {
            this.ApplicationUser = await _userManager.GetUserAsync(this.User);
        }
    }
}
