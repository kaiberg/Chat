using System.ComponentModel.DataAnnotations;
using chat.Server.Data;

namespace chat.Server.Models
{
    public class Message
    {
        // later use for editing old messages
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 1)]
        public string Content { get; set; }
        public DateTime Created { get; init; }
        public string SenderId { get; init; }
        public virtual ApplicationUser? Sender { get; init; }
    }

    public class PrivateMessage : Message
    {
        public string RecieverId { get; set; }

        public ApplicationUser? Reciever { get; set; }
    }
}
