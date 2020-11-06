using Duraid.Common.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Posts
{
    public interface IPostServices
    {
        Task<PostDTO> GetPostAsync(Guid postId);
        Task<IEnumerable<PostDTO>> GetPostsAsync();
    }
}
