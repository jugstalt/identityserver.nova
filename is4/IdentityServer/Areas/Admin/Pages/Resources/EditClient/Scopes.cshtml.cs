using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Legacy.DbContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer.Areas.Admin.Pages.Resources.EditClient
{
    public class ScopesModel : EditClientModel
    {
        public ScopesModel(IClientDbContext clientDbContext)
        {
            _clientDb = clientDbContext as IClientDbContextModify;
        }

        async public Task<IActionResult> OnGet(string id)
        {
            await SetCurrentClient(id);

            return Page();
        }
    }
}
