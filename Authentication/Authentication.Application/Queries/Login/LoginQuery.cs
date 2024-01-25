using Authentication.Application.ViewModels;
using MediatR;

namespace Authentication.Application.Queries.Login;

public record LoginQuery(
    string Email,
    string Password
    ) : IRequest<AuthenticationResponse>;
