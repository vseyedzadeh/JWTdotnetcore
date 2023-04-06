using JWTdotnetcore.DTOs;
using JWTdotnetcore.Models;
using JWTdotnetcore.RepoContracts;

namespace JWTdotnetcore.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly List<UserDto> users = new List<UserDto>();

        public UserRepository()
        {
            users.Add(new UserDto
            {
                UserName = "joydipkanjilal",
                Password = "joydip123",
                Role = "manager"
            });
            users.Add(new UserDto
            {
                UserName = "michaelsanders",
                Password = "michael321",
                Role = "developer"
            });
            users.Add(new UserDto
            {
                UserName = "stephensmith",
                Password = "stephen123",
                Role = "tester"
            });
            users.Add(new UserDto
            {
                UserName = "rodpaddock",
                Password = "rod123",
                Role = "admin"
            });
            users.Add(new UserDto
            {
                UserName = "rexwills",
                Password = "rex321",
                Role = "admin"
            });
        }
        public UserDto GetUser(User user)
        {
            return users.Where(x => x.UserName.ToLower() == user.UserName.ToLower()
                && x.Password == user.Password).FirstOrDefault();
        }
    }
}
