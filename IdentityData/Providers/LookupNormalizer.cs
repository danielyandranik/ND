using Microsoft.AspNetCore.Identity;

namespace IdentityData.Providers
{
    public class LookupNormalizer : ILookupNormalizer
    {
        public string NormalizeName(string name)
        {
            return name.ToLower();
        }

        public string NormalizeEmail(string email)
        {
            return email.ToLower();
        }
    }
}