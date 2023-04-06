using JWTdotnetcore.DTOs;

namespace JWTdotnetcore.RepoContracts
{
    public interface ITokenService
    {
        string BuildToken(UserDto user);
        bool IsTokenValid(string token);
    }
}
