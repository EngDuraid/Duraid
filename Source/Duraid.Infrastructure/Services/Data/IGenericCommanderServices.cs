using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data
{
    public interface IGenericCommanderServices<TEntity, TDTO>
        where TEntity : EntityBase
        where TDTO : class
    {
        Task<bool> CreateAsync(TDTO dto);

        Task DeleteAsync(Guid dto);

        Task<bool> UpdateAsync(TDTO dto);
    }
}
