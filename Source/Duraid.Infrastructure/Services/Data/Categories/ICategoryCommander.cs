using Duraid.Common.DTO;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    public interface ICategoryCommander
    {
        Task<bool> CreateCategoryAsync(CategoryDTO dto);
        Task<bool> UpdateCategoryAsync(CategoryDTO dto);
    }
}
