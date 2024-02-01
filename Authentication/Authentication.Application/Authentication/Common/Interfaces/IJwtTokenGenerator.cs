using Freelance.Domain.Entities;

namespace Freelance.Application.Authentication.Common.Interfaces;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
