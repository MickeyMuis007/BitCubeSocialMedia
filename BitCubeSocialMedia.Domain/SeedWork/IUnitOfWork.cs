﻿using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Domain.SeedWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        Task SaveAsync();
    }
}
