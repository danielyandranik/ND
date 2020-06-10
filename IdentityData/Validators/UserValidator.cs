using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityData.Validators
{
    public class UserValidator : IUserValidator<string>
    {
        public async Task<IdentityResult> ValidateAsync(UserManager<string> manager, string user)
        {
            throw new System.NotImplementedException();
        }


    }
}