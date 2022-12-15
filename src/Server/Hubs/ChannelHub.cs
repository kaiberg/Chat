using chat.Server.Data;
using chat.Shared;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace chat.Server.Hubs
{
    public class ChannelHub : Hub
    {
        private readonly ApplicationDbContext _context;
        public ChannelHub(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task SendMessage(string sender, string message)
        {
            var dt = DateTime.Now;
            await Clients.All.SendAsync("PublicMessage", sender, message, dt);

            Message m = new() { Content= message, Created = dt, SenderId = sender };
            _context.Channels.Include(c => c.Messages).First().Messages.Add(m);
            await _context.SaveChangesAsync();
        }
    }
}