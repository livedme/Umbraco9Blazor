#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0a0da08be79696f5e4c8f8b98c7fcabaf18d694"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListAncestorsFromCurrentPage), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListAncestorsFromCurrentPage.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
using Umbraco.Cms.Core.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0a0da08be79696f5e4c8f8b98c7fcabaf18d694", @"/umbraco/PartialViewMacros/Templates/ListAncestorsFromCurrentPage.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListAncestorsFromCurrentPage : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 13 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
   var selection = Model.Content.Ancestors().ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
 if (selection.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 19 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
         foreach (var item in selection.OrderBy(x => x.Level))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 825, "\"", 863, 1);
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
WriteAttributeValue("", 832, item.Url(PublishedUrlProvider), 832, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> &raquo;</li>\r\n");
#nullable restore
#line 22 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        <li>");
#nullable restore
#line 25 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
       Write(Model.Content.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 27 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListAncestorsFromCurrentPage.cshtml"
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
