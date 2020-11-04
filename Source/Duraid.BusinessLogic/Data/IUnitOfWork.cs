using Duraid.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public interface IUnitOfWork<T> : IDisposable where T : EntityBase
    {
        ICommander<T> Entity { get; }
        Task SaveAsync();
    }
}
