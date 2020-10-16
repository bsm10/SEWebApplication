using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SEWebApplication.Models;

namespace SEWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //**************************************
            //string dbName = "clients.db";
            //if (File.Exists(dbName))
            //{
            //    File.Delete(dbName);
            //}
            //using (var dbContext = new SEClientsContext())
            //{
            //    //Ensure database is created
            //    dbContext.Database.EnsureCreated();
            //    if (!dbContext.ClientItems.Any())
            //    {
            //        dbContext.ClientItems.AddRange(new Client[]
            //            {
            //                 new Client{ Id="BFEBFBFF000306A9-QB06620009-7275B46F", Email="slem555888@gmail.com", Description="Евгений пожизненная оплата)", Telephone="", IsTest=false, Exprise = "01.01.2100" },
            //                 new Client{ Id="BFEBFBFF000306C3-130511243302280-9E8D1FFB", Email="masa10@i.ua", Description="SVETA", Telephone="", IsTest=false, Exprise = "01.01.2100"  },
            //                 new Client{ Id="BFEBFBFF000406E3-MMG5S000000226BGP0073-E882D9B5", Email="masa10@i.ua", Description="SVETA-ноутбук", Telephone="", IsTest=false, Exprise = "01.01.2100"  }
            //            });
            //        dbContext.SaveChanges();
            //    }
            //    foreach (var client in dbContext.ClientItems)
            //    {
            //        Console.WriteLine($"ClientID: {client.Id}\tEmail: {client.Email}\tDescription: {client.Description}\tTelephone: {client.Telephone}, IsTest: {client.IsTest}, Exprise: {client.Exprise}");
            //    }
            //}
            //Console.ReadLine();
            //**************************************
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //webBuilder.UseKestrel(options =>
                    //                 {
                    //                     options.Limits.MaxConcurrentConnections = 100;
                    //                     //options.Limits.MaxRequestBodySize = 10 * 1024;
                    //                     //options.Limits.MinRequestBodyDataRate =
                    //                     //    new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    //                     //options.Limits.MinResponseDataRate =
                    //                     //    new MinDataRate(bytesPerSecond: 100, gracePeriod: TimeSpan.FromSeconds(10));
                    //                     //options.Listen(IPAddress.Loopback, 5500);

                    //                 });

                });
    }
}
