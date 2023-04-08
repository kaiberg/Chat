using AutoMapper;
using chat.Server.Data;
using chat.Server.Models;
using chat.Shared;
using chat.Shared.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace chat.Server.Hubs
{
    [Authorize]
    public class ChannelHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ChannelHub(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task SendMessage(string message)
        {
            var dt = DateTime.Now;
            var sender = _context.Users.Find(Context.UserIdentifier);
            Message m = new() { Content = message, Created = dt, SenderId = sender.Id, Sender = sender };

            await Clients.All.SendAsync("PublicMessage", _mapper.Map<MessageDto>(m));

            _context.Channels.Include(c => c.Messages).First().Messages.Add(m);
            await _context.SaveChangesAsync();
        }
    }
}