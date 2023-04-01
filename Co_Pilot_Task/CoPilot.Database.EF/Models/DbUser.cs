using CoPilot.Database.EF.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CoPilot.Database.EF.Models
{
    [EntityTypeConfiguration(typeof(UsersConfiguration))]
    public class DbUser : BaseEntity
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
    }
}
