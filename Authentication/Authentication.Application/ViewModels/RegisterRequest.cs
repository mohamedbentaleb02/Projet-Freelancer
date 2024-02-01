namespace Freelance.Application.ViewModels;

public record RegisterRequest(
        string FirstName,
        string LastName,
        string Email,
        string Password
    );

