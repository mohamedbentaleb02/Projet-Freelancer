using Authentication.Application.Commands.Register;
using Authentication.Application.ViewModels;

namespace Authentication.Application.Services;

public interface IRegisterService
{
    Task<AuthenticationResponse> Register(RegisterCommand command);
}
