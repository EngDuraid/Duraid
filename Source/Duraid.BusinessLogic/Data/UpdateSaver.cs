using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class UpdateSaver<T> : Updater<T>, IUpdateSaver<T>
   where T : EntityBase
    {
        readonly IDataContext _dataContext;
        readonly IDateTime dateTime;
        public UpdateSaver(IDataContext dataContext, IDateTime dateTime) : base(dataContext)
        {
            _dataContext = dataContext;
            this.dateTime = dateTime;
        }

        public async Task<int> SaveUpdateAsync(T entity, CancellationToken cancellationToken = default)
        {
            entity.EditedDate = dateTime.Now;
            Update(entity);
            return await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
