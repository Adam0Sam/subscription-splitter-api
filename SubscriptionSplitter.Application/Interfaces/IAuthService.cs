using SubscriptionSplitter.Application.Features.Auth.DTO;

namespace SubscriptionSplitter.Application.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponse> RegisterAsync(RegisterUserRequest request);
        Task<AuthResponse> LoginAsync(LoginUserRequest request);
    }
}
