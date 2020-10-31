using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();
        Task<CategoryDTO> GetCategoryAsync(Guid categoryId);
        Task<bool> CategoryExistAsync(Guid categoryId);
    }
}
