using System;
using Test.Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Test.Domain.Models;

namespace Test.Migrations
{
    public class ConsoleStartup
    {
        public ConsoleStartup()
        {
            var builder = new ConfigurationBuilder()
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            //.. for test
            string mySqlConnectionString = Environment.GetEnvironmentVariable("MYSQL_DB_CONNECTION_STRING");
            Console.WriteLine(mySqlConnectionString);
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string mySqlConnectionString = Environment.GetEnvironmentVariable("MYSQL_DB_CONNECTION_STRING");

            services.AddDbContext<testContext>(options =>
            {
                options.UseMySql(mySqlConnectionString, ServerVersion.AutoDetect(mySqlConnectionString));
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
