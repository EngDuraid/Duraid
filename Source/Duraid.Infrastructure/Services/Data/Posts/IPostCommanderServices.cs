using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Posts
{
    public interface IPostCommanderServices: IGenericCommanderServices<Post,PostDTO>
    {
        //Task<bool> CreatePostAsync(PostDTO dto);
        new Task<bool> DeleteAsync(Guid dto);
        //Task<bool> UpdatePostAsync(PostDTO dto);
    }
}