using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Test.Domain;
using Test.Domain.Models;

namespace Test.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicando migraciones...");
            var webHost = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<ConsoleStartup>()
                .Build();
            using (var context = (testContext)webHost.Services.GetService(typeof(testContext)))
            {
                context.Database.Migrate();
            }
            Console.WriteLine("Migraciones aplicadas correctamente");
        }
    }
}
