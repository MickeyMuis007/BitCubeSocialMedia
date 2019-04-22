using AutoMapper;
using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.Auth;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Logics
{
    public class UserLogic : IUserLogic
    {
        #region Fields
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion Fields

        #region Constructor
        public UserLogic(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion Constructor

        public async Task<bool> AddUser(SignUpModel signUpModel)
        {
            var isSuccess = true;
            try
            {
                if (!await _unitOfWork.UserRepository.EmailExistAsync(signUpModel.Email))
                {
                    signUpModel.Password = BCrypt.Net.BCrypt.HashPassword(signUpModel.Password);
                    var user = _mapper.Map<User>(signUpModel);                    
                    await _unitOfWork.UserRepository.Insert(user);
                    await _unitOfWork.SaveAsync();
                }
                else
                {
                    //TODO: Throw custom exist exception
                    isSuccess = false;
                }
            }
            catch(Exception e)
            {
                // TODO: Throw exception to be handle by middle ware, still to implement
                isSuccess = false;
            }
            return isSuccess;
        }

        public async Task<bool> ValidateCredentials(SignInModel signInModel)
        {
            var isValid = true;
            User user = await _unitOfWork.UserRepository.GetByEmailAsync(signInModel.Email);
            if(user != null)
            {
                if(!BCrypt.Net.BCrypt.Verify(signInModel.Password, user.Password))
                {
                    //TODO throw custom exception incorrect password
                    isValid = false;
                }
            }
            else
            {
                //TODO: Throw custom exception not exist
                isValid = false;
            }
            return isValid;
        }
    }
}
