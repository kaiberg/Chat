using Microsoft.AspNetCore.SignalR;

namespace chat.Server.Hubs
{
    public class ChannelHub : Hub
    {
        public async Task SendMessage(string sender, string message)
        {
            var dt = DateTime.Now;
            await Clients.All.SendAsync("PublicMessage", sender, message, dt);
        }
    }
}