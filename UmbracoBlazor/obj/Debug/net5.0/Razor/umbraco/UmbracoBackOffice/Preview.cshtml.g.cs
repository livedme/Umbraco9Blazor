#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "075c22550e474611c855e1ba4015922536394fc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_UmbracoBackOffice_Preview), @"mvc.1.0.view", @"/umbraco/UmbracoBackOffice/Preview.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.Configuration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Core.WebAssets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Infrastructure.WebAssets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Web.BackOffice.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Cms.Web.BackOffice.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"075c22550e474611c855e1ba4015922536394fc2", @"/umbraco/UmbracoBackOffice/Preview.cshtml")]
    public class umbraco_UmbracoBackOffice_Preview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Umbraco.Cms.Core.Editors.BackOfficePreviewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("canvasdesignerPanel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-mouseover", new global::Microsoft.AspNetCore.Html.HtmlString("outlinePositionHide()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("previewController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-class", new global::Microsoft.AspNetCore.Html.HtmlString("{\'tabbing-active\': tabbingActive === true}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-click", new global::Microsoft.AspNetCore.Html.HtmlString("windowClickHandler($event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 22 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
  
    var disableDevicePreview = Model.DisableDevicePreview.ToString().ToLowerInvariant();

    var EndLabel = LocalizedTextService.Localize("preview", "endLabel");
    var EndTitle = LocalizedTextService.Localize("preview", "endTitle");
    var OpenWebsiteLabel = LocalizedTextService.Localize("preview", "openWebsiteLabel");
    var OpenWebsiteTitle = LocalizedTextService.Localize("preview", "openWebsiteTitle");
    var returnToPreviewHeadline = LocalizedTextService.Localize("preview", "returnToPreviewHeadline");
    var returnToPreviewDescription = LocalizedTextService.Localize("preview", "returnToPreviewDescription");
    var returnToPreviewAcceptButton = LocalizedTextService.Localize("preview", "returnToPreviewAcceptButton");
    var returnToPreviewDeclineButton = LocalizedTextService.Localize("preview", "returnToPreviewDeclineButton");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075c22550e474611c855e1ba4015922536394fc27940", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>Umbraco Preview</title>\r\n    <meta name=\"robots\" content=\"noindex, nofollow\">\r\n    <meta name=\"pinterest\" content=\"nopin\" />\r\n\r\n    ");
#nullable restore
#line 42 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
Write(Html.Raw(await RuntimeMinifier.RenderCssHereAsync(BackOfficeWebAssets.UmbracoPreviewCssBundleName)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n        window.umbLocalizedVars = {\r\n            \'returnToPreviewHeadline\': \'");
#nullable restore
#line 46 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                   Write(returnToPreviewHeadline);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'returnToPreviewDescription\':\'");
#nullable restore
#line 47 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                     Write(returnToPreviewDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'returnToPreviewAcceptButton\':\'");
#nullable restore
#line 48 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                      Write(returnToPreviewAcceptButton);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n            \'returnToPreviewDeclineButton\':\'");
#nullable restore
#line 49 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                       Write(returnToPreviewDeclineButton);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n        };\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "075c22550e474611c855e1ba4015922536394fc210816", async() => {
                WriteLiteral("\r\n    <div class=\"wait\" ng-show=\"!frameLoaded\"></div>\r\n\r\n");
#nullable restore
#line 56 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
     if (!string.IsNullOrWhiteSpace(Model.PreviewExtendedHeaderView))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
   Write(await Html.PartialAsync(Model.PreviewExtendedHeaderView));

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                                                 
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div id=\"demo-iframe-wrapper\" class=\"{{previewDevice.css}}\">\r\n        <preview-i-frame src=\"pageUrl\" on-loaded=\"onFrameLoaded(iframe)\"></preview-i-frame>\r\n    </div>\r\n    <div class=\"canvasdesigner\"");
                BeginWriteAttribute("ng-init", " ng-init=\"", 3049, "\"", 3125, 8);
                WriteAttributeValue("", 3059, "showDevicesPreview", 3059, 18, true);
                WriteAttributeValue(" ", 3077, "=", 3078, 2, true);
                WriteAttributeValue(" ", 3079, "true;", 3080, 6, true);
                WriteAttributeValue(" ", 3085, "showDevices", 3086, 12, true);
                WriteAttributeValue(" ", 3097, "=", 3098, 2, true);
                WriteAttributeValue(" ", 3099, "!", 3100, 2, true);
#nullable restore
#line 64 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 3101, disableDevicePreview, 3101, 23, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3124, ";", 3124, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" ng-mouseenter=""positionSelectedHide()"">
        <div class=""menu-bar selected"">

            <div class=""menu-bar__title"">Preview Mode</div>

            <div class=""menu-bar__right-part"">

                <div class=""preview-menu-option"" ng-class=""{'--open': sizeOpen === true}"" ng-click=""$event.stopPropagation()"">
                    <button class=""menu-bar__button umb-outline"" ng-click=""toggleSizeOpen()""><i class=""icon {{previewDevice.icon}}""></i><span>{{previewDevice.title}}</span></button>
                    <div class=""dropdown-menu"">
                        <button ng-repeat=""device in devices"" class=""menu-bar__button umb-outline"" ng-class=""{ '--active':previewDevice === device }"" ng-click=""updatePreviewDevice(device)"">
                            <i class=""icon {{device.icon}}""></i><span>{{device.title}}</span>
                        </button>
                    </div>
                </div>

");
#nullable restore
#line 80 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                 if (Model.Languages != null && Model.Languages.Count() > 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""preview-menu-option"" ng-class=""{'--open': cultureOpen === true}"" ng-click=""$event.stopPropagation()"">
                        <button class=""menu-bar__button umb-outline"" ng-click=""toggleCultureOpen()""><i class=""icon icon-globe-europe---africa""></i><span>{{currentCulture.title}}</span></button>
                        <div class=""dropdown-menu"">
");
#nullable restore
#line 85 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                             foreach (var language in Model.Languages)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <button class=\"menu-bar__button umb-outline\"");
                BeginWriteAttribute("ng-class", " ng-class=\"", 4718, "\"", 4862, 15);
                WriteAttributeValue("", 4729, "{", 4729, 1, true);
                WriteAttributeValue(" ", 4730, "\'--active\':", 4731, 12, true);
                WriteAttributeValue(" ", 4742, "currentCultureIso", 4743, 18, true);
                WriteAttributeValue(" ", 4760, "===", 4761, 4, true);
                WriteAttributeValue(" ", 4764, "\'", 4765, 2, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 4766, language.IsoCode, 4766, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4783, "\'", 4783, 1, true);
                WriteAttributeValue(" ", 4784, "||", 4785, 3, true);
                WriteAttributeValue(" ", 4787, "(", 4788, 2, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 4789, language.IsDefault.ToString().ToLower(), 4789, 40, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 4829, "&&", 4830, 3, true);
                WriteAttributeValue(" ", 4832, "currentCultureIso", 4833, 18, true);
                WriteAttributeValue(" ", 4850, "===", 4851, 4, true);
                WriteAttributeValue(" ", 4854, "null)", 4855, 6, true);
                WriteAttributeValue(" ", 4860, "}", 4861, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("ng-click", " ng-click=\"", 4863, "\"", 4908, 3);
                WriteAttributeValue("", 4874, "changeCulture(\'", 4874, 15, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 4889, language.IsoCode, 4889, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4906, "\')", 4906, 2, true);
                EndWriteAttribute();
                BeginWriteAttribute("ng-init", " ng-init=\"", 4909, "\"", 5022, 8);
                WriteAttributeValue("", 4919, "registerCulture(\'", 4919, 17, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 4936, language.IsoCode, 4936, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4953, "\',", 4953, 2, true);
                WriteAttributeValue(" ", 4955, "\'", 4956, 2, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 4957, language.CultureName, 4957, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4978, "\',", 4978, 2, true);
#nullable restore
#line 87 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue(" ", 4980, language.IsDefault.ToString().ToLower(), 4981, 40, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5021, ")", 5021, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <i class=\"icon icon-globe-europe---africa\"></i><span>");
#nullable restore
#line 88 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                                                                    Write(language.CultureName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                </button>\r\n");
#nullable restore
#line 90 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 93 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button ng-click=\"openInBrowser()\"");
                BeginWriteAttribute("title", " title=\"", 5350, "\"", 5375, 1);
#nullable restore
#line 95 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 5358, OpenWebsiteTitle, 5358, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"menu-bar__button umb-outline\">\r\n                    <i class=\"icon icon-out\"></i><span>");
#nullable restore
#line 96 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                                  Write(OpenWebsiteLabel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </button>\r\n\r\n                <button ng-click=\"exitPreview()\"");
                BeginWriteAttribute("title", " title=\"", 5574, "\"", 5591, 1);
#nullable restore
#line 99 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 5582, EndTitle, 5582, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"menu-bar__button umb-outline\">\r\n                    <i class=\"icon icon-power\"></i><span>");
#nullable restore
#line 100 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
                                                    Write(EndLabel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </button>\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    ");
#nullable restore
#line 108 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
Write(await Html.BareMinimumServerVariablesScriptAsync(BackOfficeServerVariables));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script src=\"../lib/lazyload-js/LazyLoad.min.js\"></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 5947, "\"", 6062, 1);
#nullable restore
#line 111 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoBackOffice\Preview.cshtml"
WriteAttributeValue("", 5953, Url.GetUrlWithCacheBust("Application", "Preview", null, HostingEnvironment, UmbracoVersion, RuntimeMinifier), 5953, 109, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILocalizedTextService LocalizedTextService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProfilerHtml ProfilerHtml { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRuntimeMinifier RuntimeMinifier { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<GlobalSettings> GlobalSettings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment HostingEnvironment { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUmbracoVersion UmbracoVersion { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BackOfficeServerVariables BackOfficeServerVariables { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IBackOfficeSignInManager SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Umbraco.Cms.Core.Editors.BackOfficePreviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
