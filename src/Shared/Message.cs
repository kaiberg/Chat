using System.ComponentModel.DataAnnotations;

namespace chat.Shared
{
    public class Message
    {
        // later use for editing old messages
        public int Id { get; set; }

        [StringLength(255, MinimumLength = 1)]
        public string Content { get; set; }
        public int CreatorId { get; set; }
        public virtual ApplicationUser? Creator { get; set; }


    }
}
