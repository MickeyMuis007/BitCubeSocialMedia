using BitCubeSocialMedia.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.AggregateModels.UserAggregate
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        
    }
}
