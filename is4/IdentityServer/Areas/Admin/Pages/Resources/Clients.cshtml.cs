using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer.Legacy.DbContext;
using IdentityServer4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer.Areas.Admin.Pages.Resources
{
    public class ClientsModel : PageModel
    {
        private IClientDbContextModify _clientDb = null;
        public ClientsModel(IClientDbContext clientDbContext)
        {
            _clientDb = clientDbContext as IClientDbContextModify;
        }

        async public Task<IActionResult> OnGetAsync()
        {
            if (_clientDb != null)
            {
                Input = new AllClientsModel()
                {
                    Clients = await _clientDb.GetAllClients()
                };
            }

            return Page();
        }

        [BindProperty]
        public AllClientsModel Input { get; set; }

        public class AllClientsModel
        {
            public IEnumerable<Client> Clients { get; set; }
        }
    }
}
