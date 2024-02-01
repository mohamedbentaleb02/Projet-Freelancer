using Freelance.Application.ViewModels;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public record RegisterCommand(
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string Role) : IRequest<AuthenticationResponse>;
