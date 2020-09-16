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

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {

            modelBuilder.Entity<AppClientUser>()
                .HasKey(t => new { t.AppClientId, t.UserId });

            modelBuilder.Entity<AppClientUser>()
                .HasOne(acu => acu.User)
                .WithMany(user => user.AppClientUsers)
                .HasForeignKey(acu => acu.UserId);
            
            modelBuilder.Entity<AppClientUser>()
                .HasOne(acu => acu.AppClient)
                .WithMany(ac => ac.AppClientUsers)
                .HasForeignKey(acu => acu.AppClientId);
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<AppClient> AppClients { get; set; }

        public DbSet<User> Users { get; set; }
        
        public DbSet<AccessRole> AccessRoles { get; set; }
        
        public DbSet<AppClientUser> AppClientUsers { get; set; }

        public DbSet<PoeAccount> PoeAccounts { get; set; }

        
    }
}