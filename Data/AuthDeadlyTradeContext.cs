using Microsoft.EntityFrameworkCore;
using AuthDeadlyTrade.Api.Models;

namespace AuthDeadlyTrade.Api.Data
{
    public class AuthDeadlyTradeContext : DbContext
    {
        public AuthDeadlyTradeContext(DbContextOptions<AuthDeadlyTradeContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<AppClient> AppClients { get; set; }
    }
}