using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.Builders;
using BitCubeSocialMedia.Domain.AggregateModels.UserAggregate.ChildEntities;
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

        private void SeedData(EntityTypeBuilder<Friend> builder)
        {
            builder.HasData(
                BuilderFactory<FriendBuilder>.Create()
                    .SetId(1)
                    .SetFriend1Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E1"))
                    .SetFriend2Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E2"))
                    .Build(),
                BuilderFactory<FriendBuilder>.Create()
                    .SetId(2)
                    .SetFriend1Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E1"))
                    .SetFriend2Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E3"))
                    .Build(),
                BuilderFactory<FriendBuilder>.Create()
                    .SetId(3)
                    .SetFriend1Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E1"))
                    .SetFriend2Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4"))
                    .Build(),
                BuilderFactory<FriendBuilder>.Create()
                    .SetId(4)
                    .SetFriend1Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E2")) 
                    .SetFriend2Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4"))
                    .Build(),
                BuilderFactory<FriendBuilder>.Create()
                    .SetId(5)
                    .SetFriend1Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E3"))
                    .SetFriend2Id(new Guid("F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4"))
                    .Build()
            );
        }
    }
}
