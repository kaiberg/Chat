using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Cryptography.X509Certificates;
using chat.Shared;

namespace chat.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        private DbSet<PrivateMessage> _privateMessages { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Group> Groups { get; set; }

        public DbSet<Channel> Channels { get; set; }

        public List<PrivateMessage> PrivateMessages(string user1, string user2) =>
            _privateMessages.Where(s =>
            (s.SenderId == user1 && s.RecieverId == user2) ||
            (s.SenderId == user2 && s.RecieverId == user1))
            .OrderBy(s => s.Created)
            .ToList();

    }
}