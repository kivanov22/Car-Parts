namespace Car_Parts_API.Infrastructure.Models
{
    public class User
    {
        public string Username { get; set; } = string.Empty;

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
