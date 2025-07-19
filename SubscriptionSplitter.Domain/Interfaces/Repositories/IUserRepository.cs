using SubscriptionSplitter.Domain.Entities;

namespace SubscriptionSplitter.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id);
        Task<User?> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
}
