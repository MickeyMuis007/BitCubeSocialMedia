using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.SeedWork;
using BitCubeSocialMedia.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Repositories.UserRepo
{
    public class UserRepository : Repository<User, Guid>, IRepository<User, Guid>
    {
        public UserRepository(BitCubeSocialMediaContext context) : base(context) { }
    }
}
