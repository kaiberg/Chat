using Microsoft.AspNetCore.Identity;

namespace chat.Shared
{
    public class ApplicationUser : IdentityUser
    {
        public string ImageUrl { get; set; }
    }
}