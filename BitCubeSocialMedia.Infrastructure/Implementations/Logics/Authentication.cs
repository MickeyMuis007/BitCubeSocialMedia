using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.Auth;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Logics
{
    public class Authentication : IAuthentication
    {
        #region Fields
        private readonly IUserLogic _userLogic;
        #endregion Fields

        #region Constructors
        public Authentication(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        #endregion Constructors

        #region Methods
        public async Task SignInUser(SignInModel signInModel)
        {
            if (await _userLogic.ValidateCredentials(signInModel))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, signInModel.Email),
                    new Claim("name", signInModel.Email)
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, "name", null);
            }
        }

        public Task SignoutUser()
        {
            throw new NotImplementedException();
        }

        public Task SignUpUser(SignUpModel signUpModel)
        {
            throw new NotImplementedException();
        }
        #endregion Methods
    }
}
