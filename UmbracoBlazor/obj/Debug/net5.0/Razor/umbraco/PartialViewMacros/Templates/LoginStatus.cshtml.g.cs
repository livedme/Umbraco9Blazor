#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8219cd6d5ee45c18a8e9537a9ff559483aa257a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_LoginStatus), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/LoginStatus.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
using Umbraco.Cms.Web.Common.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
using Umbraco.Cms.Web.Website.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8219cd6d5ee45c18a8e9537a9ff559483aa257a", @"/umbraco/PartialViewMacros/Templates/LoginStatus.cshtml")]
    public class umbraco_PartialViewMacros_Templates_LoginStatus : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
  
    var isLoggedIn = Context.User?.Identity?.IsAuthenticated ?? false;
    var logoutModel = new PostRedirectModel();
    // You can modify this to redirect to a different URL instead of the current one
    logoutModel.RedirectUrl = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
 if (isLoggedIn)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"login-status\">\r\n\r\n        <p>Welcome back <strong>");
#nullable restore
#line 18 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
                           Write(Context.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>!</p>\r\n\r\n");
#nullable restore
#line 20 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
         using (Html.BeginUmbracoForm<UmbLoginStatusController>("HandleLogout", new { RedirectUrl = logoutModel.RedirectUrl }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-primary\">Log out</button>\r\n");
#nullable restore
#line 23 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 26 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\LoginStatus.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
