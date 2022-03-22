using Microsoft.EntityFrameworkCore;
using TravelAgentWeb.Models;

namespace TaravelAgentWeb.Data
{
    public class TravelAgentDbContext : DbContext
    {
        public TravelAgentDbContext(DbContextOptions<TravelAgentDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<WebhookSecret> SubscriptionSecrets {get; set;}
    }
}