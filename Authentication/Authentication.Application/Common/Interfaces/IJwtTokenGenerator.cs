using Authentication.Domain.Entities;

namespace Authentication.Application.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
