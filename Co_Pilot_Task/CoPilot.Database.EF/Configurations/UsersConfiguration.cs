using CoPilot.Database.EF.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CoPilot.Database.EF.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<DbUser>
    {
        public void Configure(EntityTypeBuilder<DbUser> builder)
        {
            builder
                .Property(b => b.Email)
                .IsRequired();

            builder
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}
