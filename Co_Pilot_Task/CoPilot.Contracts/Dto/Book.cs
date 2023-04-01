namespace CoPilot.Contracts.Dto;
public class Book
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public string Publisher { get; set; }

    public string ISBN { get; set; }

    public DateTimeOffset PublicationDate { get; set; }

    public string Genres { get; set; }

    public short NumberOfPages { get; set; }

    public string[] Tags { get; set; }

    public int ContributorId { get; set; }

    public User Contributor { get; set; }

    public int CurrentKeeperId { get; set; }

    public User CurrentKeeper { get; set; }
}
