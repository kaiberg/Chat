using Microsoft.AspNetCore.SignalR;

namespace chat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string sender, string message)
        {
            await Clients.All.SendAsync("PublicMessage", sender, message);
        }

        public async Task SendPrivateMessage(string sender, string reciever, string message)
        {
            await Clients.Client(reciever).SendAsync("PrivateMessage", sender, message);
        }

        public async Task SendGroupMessage(string sender, string group, string message)
        {
            // if sender is in group 
            //await Clients;
            await Clients.Group(group).SendAsync("GroupMessage", sender, message);
        }

        public async Task InviteToGroup(string inviter, string invitee, string group, string message)
        {
            // if sender is in group 
            //await Clients;
            await Groups.AddToGroupAsync(invitee, group);
        }

        public async Task LeaveGroup(string user, string group)
        {
            // if sender is in group 
            //await Clients;
            await Groups.RemoveFromGroupAsync(user, group);
        }
    }
}