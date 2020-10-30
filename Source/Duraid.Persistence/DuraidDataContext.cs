using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.Persistence
{
    public class DuraidDataContext :DbContext, IDataContext
    {
        public DuraidDataContext(DbContextOptions<DuraidDataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlite(connectionString: @"Data Source=./PingMonitorDb.db");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            //modelBuilder.Entity<Test>()
            //.HasOne(p => p.Ip)
            //.WithMany(b => b.Tests)
            //.OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<State>()
            //.HasOne(p => p.Test)
            //.WithMany(b => b.States)
            //.OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Notification>()
            //.HasOne(p => p.Test)
            //.WithMany(b => b.Notifications)
            //.OnDelete(DeleteBehavior.Cascade);


            //modelBuilder.SeedData();
        }

        public override DatabaseFacade Database => base.Database;
        public DbSet<Category> Categories {get;set;}
        public DbSet<Post> Posts {get;set;}
        public DbSet<Comment> Comments {get;set;}

        public override void Dispose()
        {
            base.Dispose();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken =default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public override DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
