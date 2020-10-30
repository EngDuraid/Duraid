using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class ReaderById<T>:IReadById<T> where T : class
    {
        readonly IDataContext _dataContext;
        public ReaderById(IDataContext dataContext)
        {
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }
        DbSet<T> Table { get; set; }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }
    }

    public interface IReadById<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
    }
}
