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
        Task<bool> CreateCategoryAsync(TDTO dto);

        Task DeleteCategoryAsync(Guid dto);

        Task<bool> UpdateCategoryAsync(TDTO dto);
    }
}
