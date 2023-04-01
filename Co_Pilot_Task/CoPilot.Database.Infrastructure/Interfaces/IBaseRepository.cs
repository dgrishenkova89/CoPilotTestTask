using CoPilot.Database.EF.Models;
using CoPilot.Database.Infrastructure.Specifications;

namespace CoPilot.Database.Infrastructure.Interfaces
{
    public interface IBaseRepository<TData> where TData : BaseEntity
    {
        Task<IReadOnlyCollection<TData>> GetArrayAsync(Specification<TData> specification,
                int skip, int take, CancellationToken cancellationToken = default);

        Task<TData> FindAnyAsync(Specification<TData> specification,
            CancellationToken cancellationToken = default);

        Task<int> SaveAsync(TData data, CancellationToken cancellationToken = default);

        Task UpdateAsync(TData data, CancellationToken cancellationToken = default);
    }
}
