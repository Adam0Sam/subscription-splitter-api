using MediatR;
using SubscriptionSplitter.Application.Features.Auth.DTO;


namespace SubscriptionSplitter.Application.Features.Auth.Commands
{
    public class LoginUserCommand : IRequest<AuthResponse>
    {
        public LoginUserRequest LoginUserRequest { get; }

        public LoginUserCommand(LoginUserRequest loginUserRequest)
        {
            LoginUserRequest = loginUserRequest;
        }
    }
}