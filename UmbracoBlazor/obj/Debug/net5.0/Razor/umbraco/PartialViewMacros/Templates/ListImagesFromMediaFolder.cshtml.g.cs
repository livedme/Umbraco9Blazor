#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81572ebff5752fa5b3a9f7d03eb1917e04cb7bc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListImagesFromMediaFolder), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListImagesFromMediaFolder.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
using Umbraco.Cms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
using Umbraco.Cms.Core.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81572ebff5752fa5b3a9f7d03eb1917e04cb7bc1", @"/umbraco/PartialViewMacros/Templates/ListImagesFromMediaFolder.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListImagesFromMediaFolder : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 19 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
   var mediaId = Model.MacroParameters["mediaId"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
 if (mediaId != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
                                                             
    var media = PublishedContentQuery.Media(mediaId);
    var selection = media.Children.ToArray();

    if (selection.Length > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 30 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
             foreach (var item in selection)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1133, "\"", 1170, 1);
#nullable restore
#line 33 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
WriteAttributeValue("", 1139, item.Url(PublishedUrlProvider), 1139, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1171, "\"", 1187, 1);
#nullable restore
#line 33 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
WriteAttributeValue("", 1177, item.Name, 1177, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </li>\r\n");
#nullable restore
#line 35 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 37 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListImagesFromMediaFolder.cshtml"
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedUrlProvider PublishedUrlProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPublishedContentQuery PublishedContentQuery { get; private set; }
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
