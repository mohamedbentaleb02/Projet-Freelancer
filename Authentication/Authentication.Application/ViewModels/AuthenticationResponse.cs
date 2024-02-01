using Freelance.Domain.Entities;


namespace Freelance.Application.ViewModels;

public record AuthenticationResponse(
        string FirstName,
        string LastName,
        string Email,
        string Token,
        string Message
    );
