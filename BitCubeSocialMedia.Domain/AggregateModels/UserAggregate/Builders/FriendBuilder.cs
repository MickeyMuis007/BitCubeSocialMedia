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

        public FriendBuilder Copy(Friend friend)
        {

            return this;
        }

        public Friend Build()
        {
            return new Friend(this);
        }
    }
}
