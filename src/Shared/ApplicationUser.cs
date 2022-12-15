using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace chat.Shared
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
    }
}