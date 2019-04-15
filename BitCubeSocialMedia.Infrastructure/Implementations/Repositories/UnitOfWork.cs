using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.SeedWork;
using BitCubeSocialMedia.Infrastructure.Implementations.Repositories.UserRepo;
using BitCubeSocialMedia.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Infrastructure.Implementations.Repositories
{
    public class UnitOfWork<TRepo> : IUnitOfWork
    {
        #region Fields
        private IUserRepository _userRepository;
        private BitCubeSocialMediaContext _context;
        #endregion Fields

        #region Properties
        public IUserRepository UserRepository {
            get
            {
                return _userRepository = _userRepository ?? new UserRepository(_context);
            }
        }
        #endregion Properties        

        #region Constructor
        public UnitOfWork(BitCubeSocialMediaContext context)
        {
            _context = context;
        }
        #endregion Constructor

        #region
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
        #endregion

    }
}
