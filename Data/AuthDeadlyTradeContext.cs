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
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseInMemoryDatabase("AuthDeadlyTrade");

        public DbSet<Product> Products { get; set; }
    }
}