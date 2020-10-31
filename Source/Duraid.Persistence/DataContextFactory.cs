using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Duraid.Persistence
{
    public class DataContextFactory : DesignTimeDbContextFactoryBase<DuraidDataContext>
    {
        protected override DuraidDataContext CreateNewInstance(DbContextOptions<DuraidDataContext> options)
        {
            return new DuraidDataContext(options);
        }
    }
}
