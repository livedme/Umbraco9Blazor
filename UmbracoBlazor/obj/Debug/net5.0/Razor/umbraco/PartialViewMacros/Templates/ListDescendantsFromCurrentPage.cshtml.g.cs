#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a6106efbe3988e240bab8771b51c814e0b4cfbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_PartialViewMacros_Templates_ListDescendantsFromCurrentPage), @"mvc.1.0.view", @"/umbraco/PartialViewMacros/Templates/ListDescendantsFromCurrentPage.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Cms.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Cms.Core.Models.PublishedContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Cms.Core.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a6106efbe3988e240bab8771b51c814e0b4cfbc", @"/umbraco/PartialViewMacros/Templates/ListDescendantsFromCurrentPage.cshtml")]
    public class umbraco_PartialViewMacros_Templates_ListDescendantsFromCurrentPage : Umbraco.Cms.Web.Common.Macros.PartialViewMacroPage
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 13 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
   var selection = Model.Content.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 16 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
 if (selection.Length > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                                            
    var naviLevel = selection[0].Level;

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul");
            BeginWriteAttribute("class", " class=\"", 867, "\"", 893, 2);
            WriteAttributeValue("", 875, "level-", 875, 6, true);
#nullable restore
#line 22 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 881, naviLevel, 881, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 24 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
         foreach (var item in selection)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1066, 1);
#nullable restore
#line 27 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 1035, item.Url(PublishedUrlProvider), 1035, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 30 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                  
                    var children = item.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray();
                    if (children.Length > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                         
                        ChildPages(children);
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </li>\r\n");
#nullable restore
#line 39 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 41 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
  
    void ChildPages(IPublishedContent[] selection)
    {
        //Ensure that we have a collection of pages
        if (selection.Length > 0)
        {
            // Get the first page in pages and get the level
            var naviLevel = selection[0].Level;

            // Add in level for a CSS hook

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul");
            BeginWriteAttribute("class", " class=\"", 1935, "\"", 1961, 2);
            WriteAttributeValue("", 1943, "level-", 1943, 6, true);
#nullable restore
#line 53 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 1949, naviLevel, 1949, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 54 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                 foreach (var item in selection)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2086, "\"", 2124, 1);
#nullable restore
#line 57 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
WriteAttributeValue("", 2093, item.Url(PublishedUrlProvider), 2093, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 60 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                          
                            var children = item.Children.Where(x => x.IsVisible(PublishedValueFallback)).ToArray();
                            if (children.Length > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                                                                                                    
                                ChildPages(children);
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </li>\r\n");
#nullable restore
#line 69 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 71 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\PartialViewMacros\Templates\ListDescendantsFromCurrentPage.cshtml"
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