using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duraid.Blazor.Services.PostCategories
{
    public interface IPostCategoryService:IGenericServices<PostCategoryDto>
    {
        Task<IEnumerable<PostCategoryDto>> GetPostCategoriesByPostIdAsync(Guid id);
    }
}
