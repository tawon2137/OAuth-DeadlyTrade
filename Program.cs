using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using AuthDeadlyTrade.Api.Data;

namespace AuthDeadlyTrade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            // SeedDataBase(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {   
                    webBuilder.UseStartup<Startup>();
                });


        /*
            Migration 방식 채택하면서 서버 시작 시 Database setup 비활성화
        */
        // private static void SeedDataBase(IHost host) 
        // {
        //     var scopeFactory = host.Services.GetRequiredService<IServiceScopeFactory>();
        //     using var scope = scopeFactory.CreateScope();
        //     var context = scope.ServiceProvider.GetRequiredService<AuthDeadlyTradeContext>();
            
        //     try 
        //     {
        //         context.Database.EnsureDeleted();
        //     }
        //     catch(Exception ex) 
        //     {

        //     }   

        //     if (context.Database.EnsureCreated())
        //     {
        //         try
        //         {
        //             SeedData.Initialize(context);
        //         }
        //         catch (Exception ex)
        //         {
        //             var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
        //             logger.LogError(ex, "A database seeding error occurred.");
        //         }
        //     }
        // }
    }
}
