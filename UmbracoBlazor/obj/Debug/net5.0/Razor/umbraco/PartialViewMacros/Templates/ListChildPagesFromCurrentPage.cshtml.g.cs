#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08accac5c10c734c730c23bee0b757c9de59f624"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListChildPagesFromCurrentPage), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListChildPagesFromCurrentPage.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
using Umbraco.Cms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
using Umbraco.Cms.Core.Models.PublishedContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
using Umbraco.Cms.Core.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08accac5c10c734c730c23bee0b757c9de59f624", @"/umbraco/PartialViewMacros/Templates/ListChildPagesFromCurrentPage.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListChildPagesFromCurrentPage : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 16 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
   var selection = Model.Content.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
 if (selection.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n");
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
         foreach (var item in selection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 804, "\"", 842, 1);
#nullable restore
#line 24 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
WriteAttributeValue("", 811, item.Url(PublishedUrlProvider), 811, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 26 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 28 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListChildPagesFromCurrentPage.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedUrlProvider PublishedUrlProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedValueFallback PublishedValueFallback { get; private set; }
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