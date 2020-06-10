using IdentityData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityData.Context.Configurations
{
    internal class UserTokenConfiguration : BaseEntityConfiguration<UserToken>
    {
        public override void Configure(EntityTypeBuilder<UserToken> builder)
        {
            base.Configure(builder);
            builder.HasNoKey();
        }
    }
}