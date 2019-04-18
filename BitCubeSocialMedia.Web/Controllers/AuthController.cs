using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<ActionResult> SignInUser(SignInModel signInModel)
        {
            await _authentication.SignInUser(signInModel);
            return Ok();
        }

        [HttpPost("signup")]
        public async Task<ActionResult> SignUpUser(SignUpModel signUpModel)
        {
            await _authentication.SignUpUser(signUpModel);
            return Ok();
        }

        [HttpGet("signout")]
        public async Task<ActionResult> SignOutUser()
        {
            await _authentication.SignOutUser();
            return Ok();
        }
        #endregion Methods
    }
}
