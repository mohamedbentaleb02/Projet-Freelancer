using Freelance.Application.ViewModels;
using MediatR;

namespace Freelance.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
    ) : IRequest<AuthenticationResponse>;
