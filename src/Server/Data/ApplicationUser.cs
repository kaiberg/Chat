using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace chat.Server.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(16, MinimumLength = 3)]
        public override string UserName { get => base.UserName; set => base.UserName = value; }
    }
}