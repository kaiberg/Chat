using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Shared.Dto
{
    public class ChannelDto
    {
        [StringLength(16, MinimumLength = 4)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; init; }
        public UserDto Owner { get; set; }
        public List<UserDto> Users { get; set; }
        public virtual List<MessageDto>? Messages { get; set; }
    }
}
