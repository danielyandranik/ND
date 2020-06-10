using IdentityData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityData.Context.Configurations
{
    internal class UserLoginConfiguration : BaseEntityConfiguration<UserLogin>
    {
        public override void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            base.Configure(builder);
            builder.HasNoKey();
        }
    }
}