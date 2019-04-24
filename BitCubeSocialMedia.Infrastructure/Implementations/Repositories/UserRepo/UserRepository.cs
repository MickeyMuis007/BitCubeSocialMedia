using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
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
            try
            {
                var user = await _context.Users.Include(t => t.Friend1s).Include(t => t.Friend2s).FirstOrDefaultAsync(t => t.Email == email);
                foreach (var friend in user.Friend1s)
                {
                    if (friend.Friend1?.Email != email)
                    {
                        friend.Friend1 = await GetByIdAsync(friend.Friend1Id);
                        user.Friends.Add(BuilderFactory<FriendBuilder>.Create().Copy(friend)
                            .SetId(friend.Id)
                            .SetFirstName(friend.Friend1.FirstName)
                            .SetLastName(friend.Friend1.LastName)
                            .SetEmail(friend.Friend1.Email)
                            .Build());
                    }
                    else
                    {
                        friend.Friend2 = await GetByIdAsync(friend.Friend2Id);
                        user.Friends.Add(BuilderFactory<FriendBuilder>.Create().Copy(friend)
                            .SetId(friend.Id)
                            .SetFirstName(friend.Friend2.FirstName)
                            .SetLastName(friend.Friend2.LastName)
                            .SetEmail(friend.Friend2.Email)
                            .Build());
                    }
                }
                foreach (var friend in user.Friend2s)
                {
                    if (friend.Friend1?.Email != email)
                    {
                        friend.Friend1 = await GetByIdAsync(friend.Friend1Id);
                        user.Friends.Add(BuilderFactory<FriendBuilder>.Create().Copy(friend)
                            .SetId(friend.Id)
                            .SetFirstName(friend.Friend1.FirstName)
                            .SetLastName(friend.Friend1.LastName)
                            .SetEmail(friend.Friend1.Email)
                            .Build());
                    }
                    else
                    {
                        friend.Friend2 = await GetByIdAsync(friend.Friend2Id);
                        user.Friends.Add(BuilderFactory<FriendBuilder>.Create().Copy(friend)
                            .SetId(friend.Id)
                            .SetFirstName(friend.Friend2.FirstName)
                            .SetLastName(friend.Friend2.LastName)
                            .SetEmail(friend.Friend2.Email)
                            .Build());
                    }
                }
                user.NotFriends.AddRange(await _context.Users.Where(t => !user.Friends.Any(a => a.Email == t.Email))
                    .Select(t => BuilderFactory<FriendBuilder>.Create()
                    .SetFirstName(t.FirstName)
                    .SetLastName(t.LastName)
                    .SetEmail(t.Email)
                    .Build()).ToListAsync());
                return user;
            }
            catch(Exception e)
            {
                throw;
            }
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
