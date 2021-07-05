using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Security;

namespace UmbracoBlazor.Models
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private SignInManager<MemberIdentityUser> SignInManager;
        private UserManager<MemberIdentityUser> MemberManager;
        private NavigationManager NavMgr;
        private ISessionStorageService sessionStorageService;
        public CustomAuthenticationStateProvider(
            ISessionStorageService _sessionStorageService,
            SignInManager<MemberIdentityUser> _signInManager,
             UserManager<MemberIdentityUser> _memberManager,
             NavigationManager _NavMgr)
        {
            sessionStorageService = _sessionStorageService;
            SignInManager = _signInManager;
            MemberManager = _memberManager;
            NavMgr = _NavMgr;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            //var userName = await sessionStorageService.GetItemAsync<string>("UserName");
            //ClaimsIdentity identity = new ClaimsIdentity();
            //if (userName != null)
            //{
            //    identity = new ClaimsIdentity(new[]{
            //        new Claim(ClaimTypes.Name, userName),
            //        }, "Identity Authentication");
            //}

            //var user = new ClaimsPrincipal(identity);


            var userName = await sessionStorageService.GetItemAsync<string>("UserName");
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            if (userName != null)
            {
                user = GetUser(userName);
            }


            return await Task.FromResult(new AuthenticationState(user));
        }

        public Task<AuthenticationState> AddUserAsAuthenticated(string username)
        {
            //   var usr = MemberManager.FindByNameAsync(username).Result;


            //ClaimsPrincipal principal =await SignInManager.CreateUserPrincipalAsync(usr);
            //SignInManager.Context.User = principal;
            //SetAuthenticationState(Task.FromResult(new AuthenticationState(principal)));


            //    var identity = new ClaimsIdentity(new[]
            //    {
            //    new Claim(ClaimTypes.Name, username),
            //}, "Identity Authentication");

            //    var user = new ClaimsPrincipal(identity);

            var user = GetUser(username);

            var response = Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(response);

            return response;
        }

        public ClaimsPrincipal GetUser(string username)
        {
            var usr = MemberManager.FindByNameAsync(username).Result;
            var principal = SignInManager.CreateUserPrincipalAsync(usr);
            SignInManager.Context.User = principal.Result;
            return principal.Result;
        }
        public async void UserLogout()
        {
            await sessionStorageService.RemoveItemAsync("UserName");
            var user = new ClaimsPrincipal(new ClaimsIdentity());

            var response = Task.FromResult(new AuthenticationState(user));
            NotifyAuthenticationStateChanged(response);
            NavMgr.NavigateTo("/");

        }
    }
}
