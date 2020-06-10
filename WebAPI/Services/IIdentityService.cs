using System.Threading.Tasks;
using WebAPI.Services.Data;

namespace WebAPI.Services
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
        
        Task<AuthenticationResult> LoginAsync(string email, string password);
    }
}