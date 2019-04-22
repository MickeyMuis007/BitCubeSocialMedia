using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using AutoMapper;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Logics
{
    public class Authentication : ControllerBase, IAuthentication
    {
        #region Fields
        private readonly IUserLogic _userLogic;
        private readonly IMapper _mapper;
        #endregion Fields

        #region Constructors
        public Authentication(IUserLogic userLogic, IMapper mapper)
        {
            _userLogic = userLogic;
            _mapper = mapper;
        }
        #endregion Constructors

        #region Methods
        public async Task<ClaimsPrincipal> SignInUser(SignInModel signInModel)
        {
            ClaimsPrincipal principle;
            if (await _userLogic.ValidateCredentials(signInModel))
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, signInModel.Email),
                    new Claim("name", signInModel.Email)
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme, "name", null);
                principle = new ClaimsPrincipal(identity);
            }
            else
            {
                //TODO: Throw custom exception
                throw new Exception("Invalid user details");
            }
            return principle;
        }

        public async Task SignOutUser()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        public async Task SignUpUser(SignUpModel signUpModel)
        {
            if(await _userLogic.AddUser(signUpModel))
            {
               
            }
            else
            {
                //TODO: Throw custom exception
                throw new Exception("Failed to sign up users");
            }
        }
        #endregion Methods
    }
}
