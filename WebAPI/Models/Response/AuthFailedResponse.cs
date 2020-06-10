using System.Collections.Generic;

namespace WebAPI.Models
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}