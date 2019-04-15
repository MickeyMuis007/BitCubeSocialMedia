using BitCubeSocialMedia.Application.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.ILogic
{
    public interface IAuthentication
    {
        Task SignInUser(SignInModel signInModel);
        Task SignoutUser();
        Task SignUpUser(SignUpModel signUpModel);
    }
}
