using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityData.Validators
{
    public class PasswordValidator : IPasswordValidator<string>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<string> manager, string user, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}