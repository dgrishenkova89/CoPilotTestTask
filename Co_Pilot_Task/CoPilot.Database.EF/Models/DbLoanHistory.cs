namespace CoPilot.Database.EF.Models
{
    public class DbLoanHistory : BaseEntity
    {
        public int BookID { get; set; }

        public virtual DbBook Book { get; set; }

        public int UserID { get; set; }

        public virtual DbUser User { get; set; }

        public DateTimeOffset LoanDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

    }
}
