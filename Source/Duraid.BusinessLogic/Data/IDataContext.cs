using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Common.Interfaces
{
    public interface IDataContext
    {
        DbSet<TEntity> Set<TEntity>()  where TEntity :class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        void Dispose();
        public DatabaseFacade Database { get; }

        DbSet<Category> Categories { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Comment> Comments { get; set; }
      
    }
}
