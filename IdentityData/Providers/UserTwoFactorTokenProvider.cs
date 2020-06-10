using System.Threading.Tasks;
using IdentityData.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityData.Providers
{
    public class UserTwoFactorTokenProvider : IUserTwoFactorTokenProvider<User>
    {
        public async Task<string> GenerateAsync(string purpose, UserManager<User> manager, User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ValidateAsync(string purpose, string token, UserManager<User> manager, User user)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<User> manager, User user)
        {
            throw new System.NotImplementedException();
        }
    }
}