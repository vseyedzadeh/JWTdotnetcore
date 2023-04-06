using JWTdotnetcore.DTOs;
using JWTdotnetcore.Models;

namespace JWTdotnetcore.RepoContracts
{
    public interface IUserRepository
    {
        UserDto GetUser(User user);
    }
}
