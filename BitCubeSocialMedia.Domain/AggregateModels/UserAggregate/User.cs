using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.AggregateModels.UserAggregate
{
    public class User : Entity<Guid>, IAggregateRoot
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        private User() { }
        public User(UserBuilder builder)
        {
            Id = builder.Id;
            FirstName = builder.FirstName;
            LastName = builder.LastName;
            Email = builder.Email;
            Password = builder.Password;
        }

    }
}
