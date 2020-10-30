using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface IUpdateSaver<T> where T : class
    {
        Task<int> SaveUpdateAsync(T entity, CancellationToken cancellationToken=default);
    }
}
