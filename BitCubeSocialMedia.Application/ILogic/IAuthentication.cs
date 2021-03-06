﻿using BitCubeSocialMedia.Application.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.ILogic
{
    public interface IAuthentication
    {
        Task<ClaimsPrincipal> SignInUser(SignInModel signInModel);
        Task SignOutUser();
        Task SignUpUser(SignUpModel signUpModel);
    }
}
