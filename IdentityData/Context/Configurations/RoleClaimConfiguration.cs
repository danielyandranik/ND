using IdentityData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityData.Context.Configurations
{
    internal class RoleClaimConfiguration : BaseEntityConfiguration<RoleClaim>
    {
        public override void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            base.Configure(builder);
        }
    }
}