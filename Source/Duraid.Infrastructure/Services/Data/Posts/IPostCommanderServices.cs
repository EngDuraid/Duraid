using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Posts
{
    public interface IPostCommanderServices: IGenericCommanderServices<Post,PostDto>
    {
        //Task<bool> CreatePostAsync(PostDto dto);
        new Task<bool> DeleteAsync(Guid dto);
        //Task<bool> UpdatePostAsync(PostDto dto);
    }
}