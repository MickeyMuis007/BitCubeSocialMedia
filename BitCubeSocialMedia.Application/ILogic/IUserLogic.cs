using BitCubeSocialMedia.Application.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.ILogic
{
    public interface IUserLogic
    {
        Task<bool> ValidateCredentials(SignInModel signInModel);
        Task<bool> AddUser(SignUpModel signUpModel);
    }
}
