using MediatR;
using SubscriptionSplitter.Application.Features.Auth.Commands;
using SubscriptionSplitter.Application.Features.Auth.DTO;
using SubscriptionSplitter.Application.Interfaces;

namespace SubscriptionSplitter.Application.Features.Auth.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, AuthResponse>
    {
        private readonly IAuthService _authService;

        public RegisterUserCommandHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<AuthResponse> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            return await _authService.RegisterAsync(request.RegisterUserRequest);
        }
    }
}
