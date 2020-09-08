using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AuthDeadlyTrade.Api.Models;

namespace AuthDeadlyTrade.Api.Data
{
    public static class SeedData
    {
        public static void Initialize(AuthDeadlyTradeContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Squeaky Bone",
                        Price = 20.99m,
                    },
                    new Product
                    {
                        Name = "Knotted Rope",
                        Price = 12.99m,
                    }
                );

                
            }

            if (!context.AppClients.Any())
            {
                context.AppClients.AddRange(
                    new AppClient
                    {
                        ClientSecret = "test",
                        ClientId = "test",
                        IsExpired = false,
                        RedirectUri = "https://test.com"
                    },
                    new AppClient
                    {
                        ClientSecret = "test2",
                        ClientId = "test2",
                        IsExpired = false,
                        RedirectUri = "https://test2.com"
                    }
                );
            }


            context.SaveChanges();
        }
    }
}