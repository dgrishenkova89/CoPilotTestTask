using CoPilot.Database.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoPilot.Database.EF.Configurations
{
    public class BooksConfiguration : IEntityTypeConfiguration<DbBook>
    {
        public void Configure(EntityTypeBuilder<DbBook> builder)
        {
            builder
                .Property(b => b.Author)
                .IsRequired();

            builder
                .Property(b => b.Publisher)
                .IsRequired();

            builder
                .Property(b => b.ContributorId)
                .IsRequired();


            builder
                .Property(b => b.CurrentKeeperId)
                .IsRequired();

            builder
                .Property(b => b.NumberOfPages)
                .IsRequired();
        }
    }
}
