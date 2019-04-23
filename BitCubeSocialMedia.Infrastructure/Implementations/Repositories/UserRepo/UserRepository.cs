using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.SeedWork;
using BitCubeSocialMedia.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Repositories.UserRepo
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(BitCubeSocialMediaContext context) : base(context) { }

        public async Task<bool> EmailExistAsync(string email)
        {
            return await _context.Users.AnyAsync(t => t.Email == email);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.Include(t => t.Friend1s).Include(t => t.Friend2s).FirstOrDefaultAsync(t => t.Email == email);
        }
    }
}
