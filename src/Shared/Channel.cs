using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat.Shared
{
    public class Channel
    {
        public int Id { get; set; }
        [StringLength(16, MinimumLength = 4)]
        public string Name { get; set; }
        public  string Description { get; set; } = string.Empty;
        public DateTime Created { get; init; } = DateTime.Now;
        public string OwnerId { get; set; }

        public ApplicationUser? Owner { get; set; }
        public List<ApplicationUser>? Users { get; set; }
        public virtual ICollection<Message>? Messages { get; set; }
    }
}
