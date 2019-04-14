using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders
{
    public class FriendBuilder: IBuild<FriendBuilder, Friend>
    {
        public int Id { get; private set; }
        public Guid Friend1Id { get; private set; }
        public Guid Friend2Id { get; private set; }

        public FriendBuilder SetId(int id)
        {
            Id = id;
            return this;
        }

        public FriendBuilder SetFriend1Id(Guid friend1Id)
        {
            Friend1Id = friend1Id;
            return this;
        }

        public FriendBuilder SetFriend2Id(Guid friend2Id)
        {
            Friend2Id = friend2Id;
            return this;
        }

        public FriendBuilder Copy(Friend friend)
        {
            Id = friend.Id;
            Friend1Id = friend.Friend1Id;
            Friend2Id = friend.Friend2Id;
            return this;
        }

        public Friend Build()
        {
            return new Friend(this);
        }
    }
}
