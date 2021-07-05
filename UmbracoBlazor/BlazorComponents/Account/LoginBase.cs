using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Authorization;
using Umbraco.Cms.Core.Security;
using System;

using Blazored.SessionStorage;
using UmbracoBlazor.Models;

namespace UmbracoBlazor.BlazorComponents.Account
{
    public class LoginBase : ComponentBase
    {

        public LoginBase()
        {
        }
        public string Error { get; set; }
        public LoginModel LoginModel { get; set; }


        [Inject]
        public AuthenticationStateProvider AuthenticationStateProvider { get; set; }

        [Inject]
        public NavigationManager NavMgr { get; set; }

        //[Inject]
        //public SignInManager<MemberIdentityUser> SignInManager { get; set; }

        [Inject]
        public SignInManager<MemberIdentityUser>? SignInManager { get; init; }

        [Inject]
        public UserManager<MemberIdentityUser> MemberManager { get; set; }

        [Inject]
        public ISessionStorageService sessionStorage { get; set; }

        //[Inject]
        //public AuthenticationStateProvider sessionStorage { get; set; }





        //[Inject]
        //public ILoginService LoginService { get; set; }
        public string userAuthenticated { get; set; }

        protected  override async Task OnInitializedAsync()
        {
            //sessionState = new SessionState();
            LoginModel = new LoginModel();

            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;
            if (user != null && user.Identity != null && user.Identity.IsAuthenticated)
            {
                NavMgr.NavigateTo("/");
            }
        }


        protected async Task FormSubmittedAsync(EditContext editContext)
        {
            
            bool formIsValid = editContext.Validate();

            if (formIsValid)
            {
                LoginModel = (LoginModel)editContext.Model;
                await LoginAsync();
            }
        }

        private  async Task LoginAsync()
        {
            Error = "";
            
            try
            {
                Error = "";
                var usr = await MemberManager.FindByNameAsync(LoginModel.Username);
                if (usr == null)
                {
                    Error = "User Not found";
                    return;
                }

                SignInResult loginResult = await SignInManager.CheckPasswordSignInAsync(usr, LoginModel.Password, false);
                if (loginResult.Succeeded == false)
                {
                    //await HandleSigningInFailedAsync("Email or Password are not match");
                    return;
                }
                if (loginResult.Succeeded)
                {
                    //    ClaimsPrincipal principal = await SignInManager.CreateUserPrincipalAsync(usr);
                    //    SignInManager.Context.User = principal;
                    //    HostAuthentication!.SetAuthenticationState(Task.FromResult(new AuthenticationState(principal)));
                    Task<AuthenticationState> authState = ((CustomAuthenticationStateProvider)AuthenticationStateProvider).AddUserAsAuthenticated(usr.UserName);
                    var user = authState.Result.User;
                    if (user.Identity.IsAuthenticated)
                    {
                        await sessionStorage.SetItemAsync<string>("UserName", usr.UserName);
                        NavMgr.NavigateTo("/");
                    }
                }
            }
            catch (Exception e)
            {
                Error = e.Message;

            }
        }
        
        protected async Task LoginClicked()
        {
            await LoginAsync();
            NavMgr.NavigateTo("/");
        }
    }
}

