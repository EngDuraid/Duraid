using Duraid.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface ICreateSaver<T> where T : EntityBase
    {
        Task<int> SaveCreatedAsync(T entity, CancellationToken cancellationToken=default);
    }
}
