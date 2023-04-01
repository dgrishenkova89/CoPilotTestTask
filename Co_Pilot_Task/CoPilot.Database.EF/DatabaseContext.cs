using CoPilot.Database.EF.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CoPilot.Database.EF
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DbBook> Books { get; set; }

        public DbSet<DbUser> Users { get; set; }

        public DbSet<DbLoanHistory> LoanHistory { get; set; }

        public DbSet<DbReservationQueue> ReservationQueue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DbBook>();
            modelBuilder.Entity<DbUser>();
        }
    }
}
