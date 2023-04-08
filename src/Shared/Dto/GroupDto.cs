using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Shared.Dto
{
    public class GroupDto
    {
        public string Name { get; set; }
        public UserDto Owner { get; set; }
        public List<UserDto> Users { get; set; }
        public List<MessageDto> Messages { get; set; }
    }
}
