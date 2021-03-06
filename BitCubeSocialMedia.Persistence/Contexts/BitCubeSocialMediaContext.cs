﻿using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
using BitCubeSocialMedia.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Persistence.Contexts
{
    public class BitCubeSocialMediaContext : DbContext
    {
        public BitCubeSocialMediaContext(DbContextOptions<BitCubeSocialMediaContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new FriendConfiguration());
        }
    }
}
