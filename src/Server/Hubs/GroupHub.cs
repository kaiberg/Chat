using chat.Server.Data;
using Microsoft.AspNetCore.SignalR;

namespace chat.Server.Hubs
{
    public class GroupHub : Hub
    {
        private readonly ApplicationDbContext _context;
        public GroupHub(ApplicationDbContext context) { 
            _context = context;
        }

        public async Task SendGroupMessage(string sender, string group, string message)
        {
            if (isInGroup(sender, group))
                await Clients.Group(group).SendAsync("GroupMessage", sender, message);
        }

        public async Task InviteToGroup(string inviter, string invitee, string group, string message)
        {
            if (isInGroup(inviter, group))
                await Groups.AddToGroupAsync(invitee, group);
        }

        public async Task LeaveGroup(string user, string group)
        {
            if(isInGroup(user, group))
                await Groups.RemoveFromGroupAsync(user, group);
        }

        private bool isInGroup(string name, string group) {
            return _context.Groups.Any(g => g.Name == group && g.Users.Any(u => u.UserName == name));    
        }
    }
}
