using Authentication.Domain.Entities;


namespace Authentication.Application.ViewModels;

public record AuthenticationResponse(
        string FirstName,
        string LastName,
        string Email,
        string Token,
        string Message
    );
