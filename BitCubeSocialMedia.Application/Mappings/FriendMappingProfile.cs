using AutoMapper;
using BitCubeSocialMedia.Application.Models.ViewModels;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
using BitCubeSocialMedia.Domain.SeedWork;
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
