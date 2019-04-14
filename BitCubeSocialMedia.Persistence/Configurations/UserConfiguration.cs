using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
using BitCubeSocialMedia.Domain.SeedWork;
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

            SeedData(builder);
        }

        private void SeedData(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                BuilderFactory<UserBuilder>.Create()
                    .SetUserId(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E1"))
                    .SetFirstName("John")
                    .SetLastName("Madison")
                    .SetEmail("johnmadison@mah")
                    .SetPassword(BCrypt.Net.BCrypt.HashPassword("JohnMadison"))
                    .Build(),
                BuilderFactory<UserBuilder>.Create()
                    .SetUserId(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E2"))
                    .SetFirstName("Adam")
                    .SetLastName("Madison")
                    .SetEmail("adammadison@mah")
                    .SetPassword(BCrypt.Net.BCrypt.HashPassword("AdamMadison"))
                    .Build(),
                BuilderFactory<UserBuilder>.Create()
                    .SetUserId(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E3"))
                    .SetFirstName("James")
                    .SetLastName("Paterson")
                    .SetEmail("jamespaterson@mah")
                    .SetPassword(BCrypt.Net.BCrypt.HashPassword("JamesPaterson"))
                    .Build(),
                BuilderFactory<UserBuilder>.Create()
                    .SetUserId(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4"))
                    .SetFirstName("Amy")
                    .SetLastName("Jackson")
                    .SetEmail("amyjackson@mah")
                    .SetPassword(BCrypt.Net.BCrypt.HashPassword("AmyJackson"))
                    .Build()
            );
        }
    }
}
