using Microsoft.AspNetCore.Identity;

namespace Car_Parts_API.Infrastructure.Models
{
    public class User:IdentityUser
    {
        public string Username { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
