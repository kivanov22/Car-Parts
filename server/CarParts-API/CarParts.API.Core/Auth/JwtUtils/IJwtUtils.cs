using CarParts.API.Infrastructure.Data.Auth;

namespace CarParts.API.Core.Auth.JwtUtils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);
        public int? ValidateJwtToken(string token);
        public RefreshToken GenerateRefreshToken(string ipAddress);
    }
}
