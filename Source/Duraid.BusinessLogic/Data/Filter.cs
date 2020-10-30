using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Duraid.BusinessLogic.Data
{
    public class Filter<T>: IFilter<T> where T : class
    {
        readonly IDataContext _dataContext;
        public Filter(IDataContext dataContext)
        {
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }
        DbSet<T> Table { get; set; }

        public IQueryable<T> Search(Expression<Func<T, bool>> expression)
        {
            try
            {
                var x = Table.Where(expression);
                return x;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public interface IFilter<T> where T : class
    {
        IQueryable<T> Search(Expression<Func<T, bool>> expression);
    }
}
