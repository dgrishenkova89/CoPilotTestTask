using CoPilot.Contracts.Dto;

namespace CoPilot.Services.Interfaces
{
    public interface IBookService
    {
        Task<IReadOnlyCollection<Book>> GetBooksListAsync(string searchString);

        Task<int> SaveAsync(Book book, CancellationToken cancellationToken);

        Task UpdateAsync(Book book, CancellationToken cancellationToken);
    }
}
