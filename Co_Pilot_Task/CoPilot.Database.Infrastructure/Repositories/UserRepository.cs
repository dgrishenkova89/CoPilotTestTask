using CoPilot.Database.EF.Models;
using CoPilot.Database.Infrastructure.Interfaces;
using CoPilot.Database.Infrastructure.Specifications;

namespace CoPilot.Database.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<DbUser> FindAnyAsync(Specification<DbUser> specification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<DbUser>> GetArrayAsync(Specification<DbUser> specification, int skip, int take, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync(DbUser data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DbUser data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
