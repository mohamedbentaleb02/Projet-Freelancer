using Authentication.Application.ViewModels;
using MediatR;

namespace Authentication.Application.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string Role) : IRequest<AuthenticationResponse>;
