using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco.Cms.Web.Common.Security;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UmbracoBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IMemberSignInManager _signInManager;

        public AccountController(IMemberSignInManager signInManager)
        {
            _signInManager = signInManager;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var result = await _signInManager.PasswordSignInAsync("test1", "1234567890", isPersistent: true, lockoutOnFailure: true);

            if (result.Succeeded)
            {
                
            }

            if (result.RequiresTwoFactor)
            {
                throw new NotImplementedException("Two factor support is not supported for Umbraco members yet");
            }

            // TODO: We can check for these and respond differently if we think it's important
            //  result.IsLockedOut
            //  result.IsNotAllowed

            // Don't add a field level error, just model level.
            ModelState.AddModelError("loginModel", "Invalid username or password");
            
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
