using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class DeleteSaver<T> : Deleter<T>, IDeleteSaver<T>
        where T : EntityBase
    {
        readonly IDataContext _dataContext;

        public DeleteSaver(IDataContext dataContext, IReadById<T> readById) : base(dataContext, readById)
        { _dataContext = dataContext; }

        public async Task<bool> SaveDeletedAsync(Guid id, CancellationToken cancellationToken = default)
        {
            try
            {
                await DeleteAsync(id);
                return await _dataContext.SaveChangesAsync(cancellationToken) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
