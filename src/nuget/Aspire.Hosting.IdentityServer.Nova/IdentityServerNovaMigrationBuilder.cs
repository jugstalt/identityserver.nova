﻿using Aspire.Hosting.ApplicationModel;

namespace Aspire.Hosting.ApplicationModel;

public class IdentityServerNovaMigrationBuilder(IResourceBuilder<IdentityServerNovaResource> resourceBuilder)
{
    internal IResourceBuilder<IdentityServerNovaResource> ResourceBuilder { get; } = resourceBuilder;

    internal int MigIdentityResourceIndex = 0;
    internal int MigApiResourceIndex = 0;
    internal int MigApiUserRoleIndex = 0;
    internal int MigApiUserIndex = 0;
    internal int MigClientIndex = 0;
}
