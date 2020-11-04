using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    public interface ICategoryCommander :IGenericCommanderServices<Category,CategoryDTO>
    {
        new Task<bool> DeleteCategoryAsync(Guid dto);
    }
}
