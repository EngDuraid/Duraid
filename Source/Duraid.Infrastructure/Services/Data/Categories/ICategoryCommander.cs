using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    public interface ICategoryCommander : IGenericCommanderServices<Category, CategoryDTO>
    {
        //Task<bool> CreateCategoryAsync(CategoryDTO dto);
        //Task<bool> UpdateCategoryAsync(CategoryDTO dto);
        new Task<bool> DeleteAsync(Guid dto);
    }
}
