﻿using Microsoft.EntityFrameworkCore;
using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public abstract class Creator<T> : ICreator<T> where T : class
    {
        readonly IDataContext _dataContext;
        public Creator(IDataContext dataContext)
        {
            _dataContext = dataContext;
            Table = _dataContext.Set<T>();
        }
        DbSet<T> Table { get; set; }
        public async Task AddAsync(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<int> Commit(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _dataContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
    public interface ICreator<T> where T : class
    {
        Task AddAsync(T entity);
        Task<int> Commit(CancellationToken cancellationToken = default);
    }
}
