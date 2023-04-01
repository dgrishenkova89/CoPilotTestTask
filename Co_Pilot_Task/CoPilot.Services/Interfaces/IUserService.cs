using CoPilot.Contracts.Dto;

namespace CoPilot.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(int userId, CancellationToken cancellationToken);

        Task<int> SaveAsync(User user, CancellationToken cancellationToken);
    }
}
