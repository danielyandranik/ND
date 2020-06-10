using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityData.Validators
{
    public class RoleValidator : IRoleValidator<string>
    {
        public async Task<IdentityResult> ValidateAsync(RoleManager<string> manager, string role)
        {
            throw new System.NotImplementedException();
        }
    }
}