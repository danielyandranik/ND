using IdentityData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityData.Context.Configurations
{
    internal class UserClaimConfiguration : BaseEntityConfiguration<UserClaim>
    {
        public override void Configure(EntityTypeBuilder<UserClaim> builder)
        {
            base.Configure(builder);
        }
    }
}