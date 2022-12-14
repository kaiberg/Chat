using System.ComponentModel.DataAnnotations;

namespace chat.Shared
{
    public class Group
    {
        [Key]
        public string Name { get; set; }
        public string OwnerId { get; set; }

        public virtual ApplicationUser? Owner { get; set; }
        public virtual ICollection<ApplicationUser>? Users { get; set; }
        public virtual ICollection<Message>? Messages { get; set; }

    }
}
