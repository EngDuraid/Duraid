using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Duraid.Common.DTO;

namespace Duraid.Infrastructure.Services.Data.PostImages
{
    public interface IPostImageServices
    {
        Task<IEnumerable<PostImageDto>> GetPostImagesByPostIdAsync(Guid postId);
        Task<PostImageDto> GetPostImageAsync(Guid postImageId);
    }
}