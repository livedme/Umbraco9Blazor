using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmbracoBlazor.BlazorComponents
{
    public class IndexBase : ComponentBase
    {
        [Inject]
        public AuthenticationStateProvider? AuthenticationStateProvider { get; init; }

        [CascadingParameter]
        protected AuthenticationState authenticationStateTask { get; set; }

        protected override async Task OnInitializedAsync()
        {
            authenticationStateTask = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            //var user = authState.User;
            //if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
            //{
            //    userAuthenticated = $"{ user.Identity.Name} is authenticated.";
            //}
            //else
            //{
            //    userAuthenticated = "The user is NOT authenticated.";
            //}
        }
    }
}
