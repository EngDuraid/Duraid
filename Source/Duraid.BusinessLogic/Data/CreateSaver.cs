using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class CreateSaver<T> : Creator<T>, ICreateSaver<T>
   where T : EntityBase
    {
        readonly IDataContext _dataContext;
        readonly IDateTime dataTime;
        public CreateSaver(IDataContext dataContext, IDateTime dataTime) : base(dataContext)
        {
            _dataContext = dataContext;
            this.dataTime = dataTime;
        }

        public async Task<int> SaveCreatedAsync(T entity, CancellationToken cancellationToken=default)
        {
            try
            {
                entity.CreatedDate = dataTime.Now;
                await AddAsync(entity);
                return await Commit(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        protected internal async Task<int> Commit(CancellationToken cancellationToken = default)
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
}
