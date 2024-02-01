using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Common.Interfaces;
using Freelance.Application.ViewModels;
using Freelance.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Data;
using System.Reflection;
using System.Text;

namespace Freelance.Application.Services;

public class RegisterService : IRegisterService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public RegisterService(
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<AuthenticationResponse> Register(RegisterCommand command)
    {
        string message;

        if (await _userManager.FindByEmailAsync(command.Email) != null)
        {
            throw new Exception("Email is already registred");
            message = "Email is already registred";
        }
        if (await _userManager.FindByNameAsync(command.FirstName) != null)
        {
            throw new Exception("username is already registred");
            message = "UserName is already registred";
        }

        var user = new IdentityUser
        {
            UserName = command.FirstName,
            Email = command.Email,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        if (await _roleManager.RoleExistsAsync(command.Role))
        {
            var result = await _userManager.CreateAsync(user, command.Password);

            if (result.Succeeded)
            {
                // Add role to user
                await _userManager.AddToRoleAsync(user, command.Role);

                message = "User created successfully!";
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                message = $"User failed to create: {errors}";
            }
        }
        else
        {
            message = "This role doesn't exist!";
        }

        //generate token
        User registredUser = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
        };

        var token = _jwtTokenGenerator.GenerateToken(registredUser);

     
        return new AuthenticationResponse(
            command.FirstName,
            command.LastName,
            command.Email,
            token, 
            message);

    }
}
