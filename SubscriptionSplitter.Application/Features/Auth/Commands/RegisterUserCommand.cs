using MediatR;
using SubscriptionSplitter.Application.Features.Auth.DTO;

namespace SubscriptionSplitter.Application.Features.Auth.Commands;

public class RegisterUserCommand(RegisterUserRequest registerUserRequest) : IRequest<AuthResponse>
{
    public RegisterUserRequest RegisterUserRequest { get; } = registerUserRequest;
}