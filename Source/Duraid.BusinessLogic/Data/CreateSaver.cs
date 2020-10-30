using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class CreateSaver<T> : Creator<T>, ICreateSaver<T>
   where T : class
    {
        readonly IDataContext _dataContext;
        public CreateSaver(IDataContext dataContext) : base(dataContext)
        {
           _dataContext = dataContext;
        }

        public async Task<int> SaveCreatedAsync(T entity, CancellationToken cancellationToken=default)
        {
            try
            {
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
