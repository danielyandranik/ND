using IdentityData.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityData.Providers
{
    public class PasswordHasher : IPasswordHasher<User>
    {
        public string HashPassword(User user, string password)
        {
            throw new System.NotImplementedException();
        }

        public PasswordVerificationResult VerifyHashedPassword(User user, string hashedPassword, string providedPassword)
        {
            throw new System.NotImplementedException();
        }
    }
}