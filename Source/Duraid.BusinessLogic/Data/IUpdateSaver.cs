using Duraid.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface IUpdateSaver<T> where T : EntityBase
    {
        Task<int> SaveUpdateAsync(T entity, CancellationToken cancellationToken=default);
    }
}
