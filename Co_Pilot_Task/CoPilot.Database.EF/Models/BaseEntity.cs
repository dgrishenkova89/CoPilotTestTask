using System.ComponentModel.DataAnnotations;

namespace CoPilot.Database.EF.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
