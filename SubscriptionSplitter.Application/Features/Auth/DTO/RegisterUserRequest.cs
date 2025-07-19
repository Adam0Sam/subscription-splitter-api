namespace SubscriptionSplitter.Application.Features.Auth.DTO;

public record RegisterUserRequest(
    string Username,
    string Email,
    string Password
);