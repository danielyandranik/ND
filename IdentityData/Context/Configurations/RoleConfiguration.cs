using IdentityData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityData.Context.Configurations
{
    internal class RoleConfiguration : BaseEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
        }
    }
}