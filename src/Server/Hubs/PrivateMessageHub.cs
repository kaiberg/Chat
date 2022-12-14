using Microsoft.AspNetCore.SignalR;

namespace chat.Server.Hubs
{
    public class PrivateMessageHub : Hub
    {
        public async Task SendPrivateMessage(string sender, string reciever, string message)
        {
            await Clients.Client(reciever).SendAsync("PrivateMessage", sender, message);
        }

        // re establish
    }
}
