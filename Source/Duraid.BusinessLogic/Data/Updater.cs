using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;

namespace Duraid.BusinessLogic.Data
{
    public abstract class Updater<T>:IUpdater<T> where T : class
    {
        readonly IDataContext _dataContext;
        public Updater(IDataContext dataContext)
        {
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }
        DbSet<T> Table { get; set; }

        public void Update(T entity)
        {
            var x = Table.Update(entity);
            x.State = EntityState.Modified;
        }
    }
    public interface IUpdater<T> where T : class
    {
        void Update(T entity);
    }
}
