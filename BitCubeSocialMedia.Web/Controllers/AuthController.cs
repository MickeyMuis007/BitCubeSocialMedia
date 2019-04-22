using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.Auth;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Web.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        #region Fields
        private readonly IAuthentication _authentication;
        #endregion Fields

        #region Constructors
        public AuthController(IAuthentication authentication)
        {
            _authentication = authentication;
        }
        #endregion Constructors

        #region Methods
        [HttpPost("signin")]
        public async Task<ActionResult> SignInUser([FromBody] SignInModel signInModel)
        {
            var principle =  await _authentication.SignInUser(signInModel);
            
            await HttpContext.SignInAsync(principle);
            return Ok();
        }

        [HttpPost("signup")]
        public async Task<ActionResult> SignUpUser([FromBody] SignUpModel signUpModel)
        {
            await _authentication.SignUpUser(signUpModel);
            return Ok();
        }

        [HttpGet("signout")]
        [Authorize]
        public async Task<ActionResult> SignOutUser()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok();
        }
        #endregion Methods
    }
}
