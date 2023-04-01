using CoPilot.Contracts.Dto;
using CoPilot.Database.Infrastructure.Interfaces;
using CoPilot.Services.Interfaces;

namespace CoPilot.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookReqpository _bookReqpository;

        public BookService(IBookReqpository repository)
        {
            _bookReqpository = repository;
        }

        public Task<IReadOnlyCollection<Book>> GetBooksListAsync(string searchString)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync(Book book, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Book book, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
