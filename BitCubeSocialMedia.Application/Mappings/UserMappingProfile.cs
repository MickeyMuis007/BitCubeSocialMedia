using AutoMapper;
using BitCubeSocialMedia.Application.Models.Auth;
using BitCubeSocialMedia.Application.Models.ViewModels;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<SignUpModel, User>();
            CreateMap<User, UserViewModel>();
        }
    }
}
