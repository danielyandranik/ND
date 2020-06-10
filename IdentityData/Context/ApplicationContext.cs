using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace IdentityData.Context
{
    public class ApplicationContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
        
    }
}