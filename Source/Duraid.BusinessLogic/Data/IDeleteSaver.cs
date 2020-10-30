using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface IDeleteSaver<T>:IDeleter<T> where T:class
    {
        Task<bool> SaveDeletedAsync(Guid id, CancellationToken cancellationToken=default);

    }
}
