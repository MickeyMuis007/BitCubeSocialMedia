using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("User");
            builder.HasAlternateKey(t => t.Email);      // Unique constraint

            builder.HasMany(t => t.Friend1s)
                .WithOne(t => t.Friend1)
                .HasForeignKey(t => t.Friend1Id)
                .OnDelete(DeleteBehavior.Restrict);

            

            builder.HasMany(t => t.Friend2s)
                .WithOne(t => t.Friend2)
                .HasForeignKey(t => t.Friend2Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(t => t.Id).IsRequired();
            builder.Property(t => t.FirstName).IsRequired();
            builder.Property(t => t.LastName).IsRequired();
            builder.Property(t => t.Email).IsRequired();
        }
    }
}
