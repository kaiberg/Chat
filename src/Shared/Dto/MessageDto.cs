using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Shared.Dto
{
    public class MessageDto
    {
        // later use for editing old messages
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 1)]
        public string Content { get; set; }
        public DateTime Created { get; init; }
        public UserDto Sender { get; init; }
    }

    public class PrivateMessageDto : MessageDto
    {
        public UserDto Reciever { get; set; }
    }
}
