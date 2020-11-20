using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.PostCategories
{
    public interface IPostCategoryCommanderServices:IGenericCommanderServices<PostCategory,PostCategoryDTO>
    {
        new Task<bool> DeleteAsync(Guid dto);
    }
}
