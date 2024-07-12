﻿using System.Collections.Generic;

namespace IdentityServer.Nova.Services.UI;

public interface IUserInterfaceService
{
    string ApplicationTitle { get; }

    string OverrideCssContent { get; }

    IDictionary<string, byte[]> MediaContent { get; }

    string LoginLayoutBodyClass { get; }

    bool DenyForgotPasswordChallange { get; }
}
