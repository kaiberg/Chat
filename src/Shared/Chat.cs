namespace chat.Shared
{
    public class Chat
    {
        public ICollection<Message> Messages { get; set; }
    }

    public class GroupChat : Chat
    {
        public Group Group { get; set; }
    }

    public class PrivateChat : Chat
    {
        public int User1Id { get; set; }
        public virtual ApplicationUser? User1 { get; set; }
        public int User2Id { get; set; }
        public virtual ApplicationUser? User2 { get; set; }
    }
}
