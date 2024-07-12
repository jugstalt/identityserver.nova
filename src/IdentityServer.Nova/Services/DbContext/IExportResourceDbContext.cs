﻿using IdentityServer.Nova.Abstractions.DbContext;
using System.Threading.Tasks;

namespace IdentityServer.Nova.Services.DbContext;

public interface IExportResourceDbContext : IResourceDbContextModify
{
    Task FlushDb();
}
