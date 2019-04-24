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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public FriendBuilder()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
        }

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

        public FriendBuilder SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public FriendBuilder SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public FriendBuilder SetEmail(string email)
        {
            Email = email;
            return this;
        }

        public FriendBuilder SetPassword(string password)
        {
            Password = password;
            return this;
        }
        public FriendBuilder Copy(Friend friend)
        {
            Id = friend.Id;
            Friend1Id = friend.Friend1Id;
            Friend2Id = friend.Friend2Id;
            FirstName = friend.FirstName;
            LastName = friend.LastName;
            Email = friend.Email;
            Password = friend.Password;
            return this;
        }

        public Friend Build()
        {
            return new Friend(this);
        }
    }
}
