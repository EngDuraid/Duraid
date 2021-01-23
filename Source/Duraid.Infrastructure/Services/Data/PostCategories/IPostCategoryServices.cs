using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.PostCategories
{
    public interface IPostCategoryServices
    {
        Task<IEnumerable<PostCategoryDto>> GetPostCategoriesByPostIdAsync(Guid postId);
        Task<IEnumerable<PostCategoryDto>> GetPostCategoriesByCategoryIdAsync(Guid categoryId);
        Task<PostCategoryDto> GetPostCategoryAsync(Guid PostCategoryId);
        Task<bool> PostCategoryExistAsync(Guid postCategoryId);
    }
}
