#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01387e7f1308bfefc8b6172623d10d8d40250078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.umbraco_UmbracoInstall_Index), @"mvc.1.0.view", @"/umbraco/UmbracoInstall/Index.cshtml")]
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
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
using Umbraco.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01387e7f1308bfefc8b6172623d10d8d40250078", @"/umbraco/UmbracoInstall/Index.cshtml")]
    public class umbraco_UmbracoInstall_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-class", new global::Microsoft.AspNetCore.Html.HtmlString("{loading:installer.loading}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Umbraco.InstallerController"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("umbracoInstallPageBody"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01387e7f1308bfefc8b6172623d10d8d402500784233", async() => {
                WriteLiteral("\r\n    <base");
                BeginWriteAttribute("href", " href=\"", 106, "\"", 146, 2);
#nullable restore
#line 8 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
WriteAttributeValue("", 113, ViewData.GetUmbracoBaseFolder(), 113, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 145, "/", 145, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n\r\n    <title>Install Umbraco</title>\r\n    <link rel=\"stylesheet\" href=\"assets/css/installer.min.css\" />\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01387e7f1308bfefc8b6172623d10d8d402500785901", async() => {
                WriteLiteral(@"

    <img src=""assets/img/application/logo_white.png"" id=""logo"" />

    <umb-loader position=""bottom""
                class=""umb-installer-loader""
                ng-if=""installer.loading""
                ng-style=""{'width': installer.progress}"">
    </umb-loader>

    <div id=""overlay"" ng-cloak ng-animate=""'fade'"" ng-show=""installer.done""></div>

    <div id=""installer"" class=""absolute-center clearfix""
         ng-cloak
         ng-animate=""'fade'""
         ng-show=""installer.configuring"">

        <div ng-if=""installer.current"" ng-switch on=""installer.current.view"">
            <div ng-switch-when=""ysod"">
                <h1>A server error occurred</h1>
                <p>This is most likely due to an error during application startup</p>
                <iframe id=""ysod""></iframe>
            </div>
            <div ng-switch-default>
                <div ng-include=""installer.current.view""></div>
            </div>
        </div>
    </div>


    <div ng-cloak ng-animate=""'fa");
                WriteLiteral(@"de'"" id=""fact"" class=""absolute-center clearfix"" ng-show=""installer.fact"">
        <h2>Did you know</h2>
        <p ng-bind-html=""installer.fact""></p>
    </div>

    <h3 ng-cloak ng-animate=""'fade'"" id=""feedback"" ng-show=""installer.feedback"">{{installer.feedback}}</h3>

    <div id=""missinglazyload"" style=""display: none;"">
        <h3>There has been a problem with the build.</h3>
        <p>This might be because you could be offline or on a slow connection. Please try the following steps</p>
        <ol>
            <li>Make sure you have <a href=""https://nodejs.org"" target=""_blank"">Node.js</a> installed.</li>
            <li>Open command prompt and cd to \src\Umbraco.Web.UI.Client.</li>
            <li>Check to see if \src\Umbraco.Web.UI.Client\node_modules folder exists (this could be hidden); if so delete it.</li>
            <li>Run npm install; if successfull the node_modules folder should be created in the Umbraco.Web.UI.Client directory.</li>
            <li>Run build\Build.bat.</li>
  ");
                WriteLiteral("      </ol>\r\n    </div>\r\n\r\n    <script type=\"text/javascript\">\r\n        var Umbraco = {};\r\n        Umbraco.Sys = {};\r\n        Umbraco.Sys.ServerVariables = {\r\n            \"installApiBaseUrl\": \"");
#nullable restore
#line 69 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
                             Write(ViewData.GetInstallApiBaseUrl());

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"umbracoBaseUrl\": \"");
#nullable restore
#line 70 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
                          Write(ViewData.GetUmbracoBaseFolder());

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"application\": {\r\n               version: \"");
#nullable restore
#line 72 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\umbraco\UmbracoInstall\Index.cshtml"
                    Write(ViewData.GetUmbracoVersion().Major);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\r\n           }\r\n        };\r\n    </script>\r\n    <script src=\"lib/lazyload-js/LazyLoad.min.js\"></script>\r\n    <script src=\"js/install.loader.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
