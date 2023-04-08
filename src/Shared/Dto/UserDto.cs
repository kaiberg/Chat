using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Shared.Dto
{
    public class UserDto
    {
        [Required]
        [DataType(DataType.Url)]
        public string ImageUrl { get; set; }
        public string UserName { get; set; }
    }
}
