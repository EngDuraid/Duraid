using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Duraid.Persistence
{
    //public class InMemoryDataContext : DbContext, IDataContext
    //{
    //    public DbSet<Client> Clients { get; set; }
    //    public DbSet<State> States { get; set; }
    //    public DbSet<Test> Tests { get; set; }
    //    public DbSet<Ip> Ips { get; set; }
    //    public DbSet<Notification> Notifications { get; set; }




    //}

    public class InMemoryDataContext : DesignTimeDbContextFactoryBase<DuraidDataContext>
    {
        protected override DuraidDataContext CreateNewInstance(DbContextOptions<DuraidDataContext> options)
        {
            return new DuraidDataContext(options);
        }
    }
    /// <summary>
    /// These packages added to create this abstract class
    /// </summary>
    /// <typeparam name="TContext"></typeparam>


    //Adding using Microsoft.Extensions.Configuration;
    //Microsoft.Extensions.Configuration.Json;
    //Microsoft.Extensions.Configuration.EnvironmentVariables;
    //Microsoft.Extensions.Configuration.FileExtention;
    //Microsoft.EntityFrameworkCore.SqlServer;

    public abstract class DesignTimeDbContextFactoryBase<TContext> :
        IDesignTimeDbContextFactory<TContext> where TContext : DbContext
    {
        private const string ConnectionStringName = "PingMonitorDatabase";
        private const string AspNetCoreEnvironment = "ASPNETCORE_ENVIRONMENT";

        public TContext CreateDbContext(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory() + string.Format("{0}..{0}PingMonitorUI", Path.DirectorySeparatorChar);
            return Create(basePath, Environment.GetEnvironmentVariable(AspNetCoreEnvironment));
        }

        protected abstract TContext CreateNewInstance(DbContextOptions<TContext> options);

        private TContext Create(string basePath, string environmentName)
        {

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.Local.json", optional: true)
                .AddJsonFile($"appsettings.{environmentName}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString(ConnectionStringName);

            return Create(connectionString);
        }

        private TContext Create(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException($"Connection string '{ConnectionStringName}' is null or empty.", nameof(connectionString));
            }

            Console.WriteLine($"DesignTimeDbContextFactoryBase.Create(string): Connection string: '{connectionString}'.");

            var optionsBuilder = new DbContextOptionsBuilder<TContext>();

            optionsBuilder.UseSqlite(connectionString);
            return CreateNewInstance(optionsBuilder.Options);
        }
    }
}
