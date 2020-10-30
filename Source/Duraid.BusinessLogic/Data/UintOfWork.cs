using Duraid.BusinessLogic.Common.Interfaces;
using Duraid.BusinessLogic.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Duraid.BusinessLogic.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly IDataContext context;
        public UnitOfWork(IDataContext context, ICommander<T> entity)
        {
            this.context = context;
            Entity = entity;
        }
        
        public ICommander<T> Entity { get; private set; }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task SaveAsync()
        {
            try
            {
                await context.SaveChangesAsync(new CancellationToken());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
