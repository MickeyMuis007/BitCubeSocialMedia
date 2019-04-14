using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Persistence.Configurations
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("Friend");
            builder.HasAlternateKey(t => new { t.Friend1Id, t.Friend2Id });

            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.Friend1Id).IsRequired();
            builder.Property(t => t.Friend2Id).IsRequired();
        }
    }
}
