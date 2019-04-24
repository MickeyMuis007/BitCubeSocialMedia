using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities
{
    public class Friend : Entity<int>, IEntity
    {
        public Guid Friend1Id { get; private set; }
        public Guid Friend2Id { get; private set; }

        public User Friend1 { get; set; }
        public User Friend2 { get; set; }

        private Friend() { }

        public Friend(FriendBuilder builder)
        {
            Id = builder.Id;
            Friend1Id = builder.Friend1Id;
            Friend2Id = builder.Friend2Id;
        }
    }
}
