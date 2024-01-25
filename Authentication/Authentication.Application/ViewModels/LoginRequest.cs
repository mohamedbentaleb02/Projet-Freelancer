namespace Authentication.Application.ViewModels;

public record LoginRequest(
    string Email,
    string Password
);
