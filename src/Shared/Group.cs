using System.ComponentModel.DataAnnotations;

namespace chat.Shared
{
    public class Group
    {
        [Key]
        public string Name { get; set; }
        public int OwnerId;
        public virtual ApplicationUser? Owner { get; set; }
        public virtual ICollection<ApplicationUser>? Users { get; set; }
    }
}
