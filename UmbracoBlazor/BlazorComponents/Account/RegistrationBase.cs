using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Website.Models;
using Umbraco.Extensions;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Scoping;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Web.Common.Security;

namespace UmbracoBlazor.BlazorComponents.Account
{
    public class RegistrationBase: ComponentBase
    {

        [Inject]
        public IMemberService memberService { get; set; }
        [Inject]
        public IMemberManager _memberManager { get; set; }
        [Inject]
        public IMemberService _memberService { get; set; }
        [Inject]
        public IMemberSignInManager _memberSignInManager { get; set; }
        [Inject]
        public IScopeProvider _scopeProvider { get; set; }
        public RegisterModel model { get; set; }
        protected override async Task OnInitializedAsync()
        {
            model = new RegisterModel()
            {
                Username = "Aminul24545122",
                Password = "sdfdsfdsfdsfdsfds",
                Email = "aminul11222@gggg.com",
                ConfirmPassword = "aminul112@gggg.com",
                Name = "Aminul Haque"
            };
        }

        //public void RegisterMe()
        //{
        //    if (memberService.GetByEmail("Aminul@gggg.com") != null)
        //    {

        //    }


        //    var memberDetails = memberService.CreateMemberWithIdentity("Aminul1231", "Aminul1@gggg.com", "Aminul Haque", "member");
        //    //memberDetails.SetValue("firstName", "Aminul");
        //    //memberDetails.SetValue("lastName", "Haque");
        //    //memberDetails.SetValue("address", "Address");
        //    //memberDetails.SetValue("city", "City");
        //    //memberDetails.SetValue("county", "Bangladesh");
        //    //memberDetails.SetValue("postCode", "6400");
        //    //memberDetails.SetValue("contactNumber", "1234567890");
        //    memberDetails.VersionId = 1;            
        //    memberDetails.IsApproved = false;//Change to true if you want to allow the member instant access, or false if they need to verify email etc before they can login
        //    memberService.AssignRole(memberId: memberDetails.Id, roleName: "Member"); // I always assign the default role
        //    //memberService.pa (memberDetails, model.Password);

        //    memberService.Save(memberDetails);


        //    //  memberService.Login(model.Email, model.Password);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[ValidateUmbracoFormRouteString]
        public async void RegisterMe()
        {
           // RegisterModel model = new RegisterModel();

            //if (ModelState.IsValid == false)
            //{
            //    return CurrentUmbracoPage();
            //}

            MergeRouteValuesToModel(model);

            IdentityResult result = await RegisterMemberAsync(true);
            if (result.Succeeded)
            {
               // TempData["FormSuccess"] = true;

                // If there is a specified path to redirect to then use it.
                if (model.RedirectUrl.IsNullOrWhiteSpace() == false)
                {
                    //return Redirect(model.RedirectUrl);
                }

                // Redirect to current page by default.
              //  return RedirectToCurrentUmbracoPage();
            }
            else
            {
                AddErrors(result);
               // return CurrentUmbracoPage();
            }
        }

        /// <summary>
        /// We pass in values via encrypted route values so they cannot be tampered with and merge them into the model for use
        /// </summary>
        /// <param name="model"></param>
        private void MergeRouteValuesToModel(RegisterModel model)
        {
            //if (RouteData.Values.TryGetValue(nameof(RegisterModel.RedirectUrl), out var redirectUrl) && redirectUrl != null)
            //{
            //    model.RedirectUrl = redirectUrl.ToString();
            //}

            //if (RouteData.TryGetValue(nameof(RegisterModel.MemberTypeAlias), out var memberTypeAlias) && memberTypeAlias != null)
            //{
            //    model.MemberTypeAlias = memberTypeAlias.ToString();
            //}

            //if (RouteData.Values.TryGetValue(nameof(RegisterModel.UsernameIsEmail), out var usernameIsEmail) && usernameIsEmail != null)
            //{
            //    model.UsernameIsEmail = usernameIsEmail.ToString() == "True";
            //}
        }

        private void AddErrors(IdentityResult result)
        {
            //foreach (var error in result.Errors)
            //{
            //    ModelState.AddModelError("registerModel", error.Description);
            //}
        }

        /// <summary>
        /// Registers a new member.
        /// </summary>
        /// <param name="model">Register member model.</param>
        /// <param name="logMemberIn">Flag for whether to log the member in upon successful registration.</param>
        /// <returns>Result of registration operation.</returns>
        private async Task<IdentityResult> RegisterMemberAsync(bool logMemberIn = true)
        {
           // using IScope scope = _scopeProvider.CreateScope(autoComplete: true);

            // U4-10762 Server error with "Register Member" snippet (Cannot save member with empty name)
            // If name field is empty, add the email address instead.
            if (string.IsNullOrEmpty(model.Name) && string.IsNullOrEmpty(model.Email) == false)
            {
                model.Name = model.Email;
            }

         //   model.Username = (model.UsernameIsEmail || model.Username == null) ? model.Email : model.Username;

            var identityUser = MemberIdentityUser.CreateNew(model.Username, model.Email, model.MemberTypeAlias);
            IdentityResult identityResult = await _memberManager.CreateAsync(
                identityUser,
                model.Password);

            if (identityResult.Succeeded)
            {
                // Update the custom properties
                // TODO: See TODO in MembersIdentityUser, Should we support custom member properties for persistence/retrieval?
                IMember member = _memberService.GetByKey(identityUser.Key);                
                if (member == null)
                {
                    // should never happen
                    throw new InvalidOperationException($"Could not find a member with key: {member.Key}.");
                }
                if (model.MemberProperties != null)
                {
                    foreach (MemberPropertyModel property in model.MemberProperties.Where(p => p.Value != null)
                        .Where(property => member.Properties.Contains(property.Alias)))
                    {
                        member.Properties[property.Alias].SetValue(property.Value);
                    }
                }
                member.IsApproved = true;

                _memberService.AssignRole(member.Id, "Microsoft");


                _memberService.Save(member);

                //if (logMemberIn)
                //{
                //    await _memberSignInManager.SignInAsync(identityUser, false);
                //}
            }

            return identityResult;

        }
    }
}
