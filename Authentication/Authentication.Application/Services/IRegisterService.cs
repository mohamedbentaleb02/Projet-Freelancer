using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.ViewModels;

namespace Freelance.Application.Services;

public interface IRegisterService
{
    Task<AuthenticationResponse> Register(RegisterCommand command);
}
