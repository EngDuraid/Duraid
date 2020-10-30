using Duraid.BusinessLogic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class UpdateSaver<T> : Updater<T>, IUpdateSaver<T>
   where T : class
    {
        readonly IDataContext _dataContext;
        public UpdateSaver(IDataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<int> SaveUpdateAsync(T entity, CancellationToken cancellationToken=default)
        {
            Update(entity);
            return await _dataContext.SaveChangesAsync(cancellationToken);
        }
    }
}
