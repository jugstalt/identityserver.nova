﻿using IdentityServerNET.Abstractions.DbContext;
using IdentityServerNET.Models.UserInteraction;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace IdentityServer.Areas.Identity.Pages.Account.Manage;

public class ManageAccountPageModel : PageModel, IManageAccountPageModel
{
    protected IUserStoreFactory _userStoreFactory;

    protected ManageAccountPageModel(IUserStoreFactory userStoreFactory)
    {
        _userStoreFactory = userStoreFactory;
    }

    async public Task<ManageAccountEditor> EditorInfos() => (await _userStoreFactory.CreateUserDbContextInstance())?.ContextConfiguration?.ManageAccountEditor;
}
