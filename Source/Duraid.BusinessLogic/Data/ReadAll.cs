using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class ReadAll<T> : IReadAll<T>
        where T : class
    {
        readonly IDataContext _dataContext;

        public ReadAll(IDataContext dataContext)
        {
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }

        DbSet<T> Table { get; set; }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var x = await Table.AsNoTracking().ToListAsync();
            return x;
        }
        
    }

    public interface IReadAll<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
