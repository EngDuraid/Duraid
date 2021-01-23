using System;
using System.Threading.Tasks;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;

namespace Duraid.Infrastructure.Services.Data.PostImages
{
    public interface IPostImageCommanderServices : IGenericCommanderServices<PostImage, PostImageDto>
    {
        new Task<bool> DeleteAsync(Guid dto);
    }
}