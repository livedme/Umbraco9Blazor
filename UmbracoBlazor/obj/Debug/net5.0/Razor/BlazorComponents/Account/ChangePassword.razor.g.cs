#pragma checksum "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2eaf37e5aebfa5ef60de3512c2777e6a6272f02"
// <auto-generated/>
#pragma warning disable 1591
namespace UmbracoBlazor.BlazorComponents.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using UmbracoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\_Imports.razor"
using UmbracoBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/ChangePassword")]
    public partial class ChangePassword : RegistrationBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
 if (!isUpdate)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label for=\"Name\">Password</label>\r\n        ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "class", "form-control");
            __builder.AddAttribute(5, "id", "Password");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
                      Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "<label for=\"Age\">ConfirmPassword</label>\r\n        ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "id", "ConfirmPassword");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
                      ConfirmPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ConfirmPassword = __value, ConfirmPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 17 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
         Error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "submit");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "value", "Update");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
                                                                          UpdatePassword

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br>\r\n    <br>");
#nullable restore
#line 23 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<p class=\"lead\">\r\n    Password updat successfully. Please click <a href=\"/Account/login\" class=\"small\">here</a> to login<br></p>");
#nullable restore
#line 28 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, @"<style>
    body {
        background-color: gray;
    }

    .page {
        width: 400px;
        margin: 0px auto;
        background-color: white;
        padding: 51px;
        margin-top: 100px;
        border-radius: 6px;
    }

    .btn-primary {
        width: 100%;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "F:\Umbraco9\Umbraco9Blazor\UmbracoBlazor\BlazorComponents\Account\ChangePassword.razor"
       
    bool isUpdate = false;
    string Error = "";
    string Password = "";
    string ConfirmPassword = "";

    private void UpdatePassword()
    {
        if (Password == ConfirmPassword)
        {
            isUpdate = true;
        }
        else
        {
            Error = "Password is not same";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
    }
}
#pragma warning restore 1591