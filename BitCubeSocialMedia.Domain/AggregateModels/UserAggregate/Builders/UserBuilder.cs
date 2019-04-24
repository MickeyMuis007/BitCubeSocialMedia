using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders
{
    public class UserBuilder : IBuild<UserBuilder, User>
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public UserBuilder()
        {
            FirstName = "";
            LastName = "";
            Email = "";
            Password = "";
        }

        public UserBuilder SetUserId(Guid userId)
        {
            Id = userId;
            return this;
        }

        public UserBuilder SetFirstName (string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public UserBuilder SetLastName (string lastName)
        {
            LastName = lastName;
            return this;
        }

        public UserBuilder SetEmail (string email)
        {
            Email = email;
            return this;
        }

        public UserBuilder SetPassword (string password)
        {
            Password = password;
            return this;
        }

        public UserBuilder Copy(User user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Password = user.Password;
            return this;
        }

        public User Build()
        {
            return new User(this);
        }
    }
}
