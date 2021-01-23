using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    public interface ICategoryCommander : IGenericCommanderServices<Category, CategoryDto>
    {
        //Task<bool> CreateCategoryAsync(CategoryDto dto);
        //Task<bool> UpdateCategoryAsync(CategoryDto dto);
        new Task<bool> DeleteAsync(Guid dto);
    }
}
