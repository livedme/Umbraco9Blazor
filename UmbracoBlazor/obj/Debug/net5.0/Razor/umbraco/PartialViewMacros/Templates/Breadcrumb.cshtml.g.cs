#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a5f78d1beb66917d17b8a4d593f6e6702a4acf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_Breadcrumb), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/Breadcrumb.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
using Umbraco.Cms.Core.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a5f78d1beb66917d17b8a4d593f6e6702a4acf9", @"/umbraco/PartialViewMacros/Templates/Breadcrumb.cshtml")]
    public class umbraco_PartialViewMacros_Templates_Breadcrumb : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 13 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
   var selection = Model.Content.Ancestors().ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
 if (selection.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"breadcrumb\">\r\n");
#nullable restore
#line 19 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
         foreach (var item in selection.OrderBy(x => x.Level))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 814, "\"", 852, 1);
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
WriteAttributeValue("", 821, item.Url(PublishedUrlProvider), 821, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> <span class=\"divider\">/</span></li>\r\n");
#nullable restore
#line 22 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        <li class=\"active\">");
#nullable restore
#line 25 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
                      Write(Model.Content.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 27 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\Breadcrumb.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedUrlProvider PublishedUrlProvider { get; private set; }
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