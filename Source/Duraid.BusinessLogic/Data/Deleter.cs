using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public abstract class Deleter<T>: IDeleter<T> where T : class
    {
        readonly IDataContext _dataContext;
        readonly IReadById<T> readById;
        public Deleter(IDataContext dataContext,IReadById<T> readById)
        {
            this.readById = readById;
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }
        DbSet<T> Table { get; set; }
        public async Task DeleteAsync(Guid id)
        {
            try
            {
                T t = await readById.GetByIdAsync(id);
                Table.Remove(t);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public interface IDeleter<T> where T : class
    {
        Task DeleteAsync(Guid id);
    }
}
