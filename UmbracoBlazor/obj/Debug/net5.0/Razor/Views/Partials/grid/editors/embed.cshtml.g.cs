#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\Partials\grid\editors\embed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9de454fc89220aad09fdd588a0db71a24dcdce11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_grid_editors_embed), @"mvc.1.0.view", @"/Views/Partials/grid/editors/embed.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\_ViewImports.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\_ViewImports.cshtml"
using UmbracoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\_ViewImports.cshtml"
using Umbraco.Cms.Web.Common.PublishedModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\_ViewImports.cshtml"
using Umbraco.Cms.Web.Common.Views;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9de454fc89220aad09fdd588a0db71a24dcdce11", @"/Views/Partials/grid/editors/embed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"101b6fad8e9844470ac7ad8ee22522fba726a6a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_grid_editors_embed : Umbraco.Cms.Web.Common.Views.UmbracoViewPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\Partials\grid\editors\embed.cshtml"
  
    string embedValue = Convert.ToString(Model.value);
    embedValue = embedValue.DetectIsJson() ? Model.value.preview : Model.value;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"video-wrapper\">\r\n\t");
#nullable restore
#line 9 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\Views\Partials\grid\editors\embed.cshtml"
Write(Html.Raw(embedValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
