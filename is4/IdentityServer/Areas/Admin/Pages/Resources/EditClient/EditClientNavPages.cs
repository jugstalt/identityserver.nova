using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Areas.Admin.Pages.Resources.EditClient
{
    public class EditClientNavPages
    {
        public static string Index => "Index";

        public static string Scopes => "Scopes";

        public static string Secrets => "Secrets";

        public static string Properties => "Properties";

        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string ScopesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Scopes);

        public static string SecretsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Secrets);

        public static string PropertiesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Properties);

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);

            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
