using MediatR;
using SubscriptionSplitter.Application.Features.Auth.Commands;
using SubscriptionSplitter.Application.Features.Auth.DTO;
using SubscriptionSplitter.Application.Interfaces;

namespace SubscriptionSplitter.Application.Features.Auth.Handlers
{
    public class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, AuthResponse>
    {
        private readonly IAuthService _authService;

        public LoginUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResponse> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            return await _authService.LoginAsync(request.LoginUserRequest);
        }
    }
}
