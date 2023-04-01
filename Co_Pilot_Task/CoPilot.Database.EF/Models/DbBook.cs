using CoPilot.Database.EF.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CoPilot.Database.EF.Models
{
    [EntityTypeConfiguration(typeof(BooksConfiguration))]
    public class DbBook : BaseEntity
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string ISBN { get; set; }

        public DateTimeOffset PublicationDate { get; set; }

        public string Genres { get; set; }

        public short NumberOfPages { get; set; }

        public string[] Tags { get; set; }

        public int ContributorId { get; set; }

        public virtual DbUser Contributor { get; set; }

        public int CurrentKeeperId { get; set; }

        public virtual DbUser CurrentKeeper { get; set; }

    }
}
