using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services
{
    public interface IGenericServices<T>
        where T : class
    {
        Task<T> Create(T model);

        Task Delete(Guid id);

        Task<IEnumerable<T>> Get();

        Task<T> Get(Guid id);

        Task<T> Update(Guid id, T model);
    }
}
