using Authentication.Application.Commands.Register;
using Authentication.Application.ViewModels;
using Mapster;

namespace Authentication.API.Common.Mapping;

public class AuthenticationMappingconfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<(RegisterRequest Request, string Role), RegisterCommand>()
            .Map(dest => dest.Role, src => src.Role)
            .Map(dest => dest, src => src.Request);

    }
}
