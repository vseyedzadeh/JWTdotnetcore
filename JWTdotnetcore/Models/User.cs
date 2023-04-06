using System.ComponentModel.DataAnnotations;

namespace JWTdotnetcore.Models
{
    public class User
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
