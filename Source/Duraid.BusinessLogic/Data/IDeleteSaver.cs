using Duraid.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface IDeleteSaver<T>:IDeleter<T> where T:EntityBase
    {
        Task<bool> SaveDeletedAsync(Guid id, CancellationToken cancellationToken=default);

    }
}
