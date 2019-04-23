using AutoMapper;
using BitCubeSocialMedia.Application.Models.ViewModels;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Application.Mappings
{
    public class FriendMappingProfile : Profile
    {
        public FriendMappingProfile()
        {
            CreateMap<Friend, FriendViewModel>();
        }
    }
}
