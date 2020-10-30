using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.BusinessLogic.Data;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class Repository<T> /*: IRepository<T>*/ where T : class
    {
        DbSet<T> Table { get; set; }
        readonly IDataContext _context;
        public Repository(IDataContext context)
        {
            _context = context;
            Table = context.Set<T>();
        }

        public async Task<T> AddEntityAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }
        
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
    }

    public class Commander<T>: ICommander<T> where T : class
    {
        readonly ICreateSaver<T> _creator;
        readonly IUpdateSaver<T> _updater;
        readonly IDeleteSaver<T> _deleter;
        public Commander(ICreateSaver<T> creator,IUpdateSaver<T> updater,IDeleteSaver<T> deleter)
        {
            _deleter = deleter;
            _updater = updater;
            _creator = creator;
        }
        public virtual async Task<int>AddAsync(T entity)
        {
            try
            {
                return await _creator.SaveCreatedAsync(entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            try
            {
                await _deleter.SaveDeletedAsync(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual async Task<int> UpdateAsync(T entity)
        {
            try
            {
                return await _updater.SaveUpdateAsync(entity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public interface ICommander<T> where T : class
    {
        Task<int> AddAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<int> UpdateAsync(T entity);
    }
}
