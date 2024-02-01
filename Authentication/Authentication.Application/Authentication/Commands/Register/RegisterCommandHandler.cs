using Freelance.Application.Services;
using Freelance.Application.ViewModels;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResponse>
{
    private readonly IRegisterService _registerservice;

    public RegisterCommandHandler(IRegisterService registerservice)
    {
        _registerservice = registerservice;
    }

    public async Task<AuthenticationResponse> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        var registerResult = await _registerservice.Register(command);

        return registerResult;
    }
}
