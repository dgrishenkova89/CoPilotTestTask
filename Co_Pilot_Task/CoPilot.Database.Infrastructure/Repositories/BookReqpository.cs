using CoPilot.Database.EF.Models;
using CoPilot.Database.Infrastructure.Interfaces;
using CoPilot.Database.Infrastructure.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoPilot.Database.Infrastructure.Repositories
{
    public class BookReqpository : IBookReqpository
    {
        public Task<DbBook> FindAnyAsync(Specification<DbBook> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<DbBook>> GetArrayAsync(Specification<DbBook> specification, int skip, int take, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync(DbBook data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DbBook data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
