using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.PostCategories
{
    public interface IPostCategoryServices
    {
        Task<IEnumerable<PostCategoryDTO>> GetPostCategoriesByPostIdAsync(Guid postId);
        Task<IEnumerable<PostCategoryDTO>> GetPostCategoriesByCategoryIdAsync(Guid categoryId);
        Task<PostCategoryDTO> GetPostCategoryAsync(Guid PostCategoryId);
        Task<bool> PostCategoryExistAsync(Guid postCategoryId);
    }
}
