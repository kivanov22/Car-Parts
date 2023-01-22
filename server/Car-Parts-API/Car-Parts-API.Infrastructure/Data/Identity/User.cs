using Microsoft.AspNetCore.Identity;

namespace Car_Parts_API.Infrastructure.Data.Identity
{
    public class User : IdentityUser
    {
        public string Username { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
