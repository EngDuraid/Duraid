using System;
using System.Threading.Tasks;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;

namespace Duraid.Infrastructure.Services.Data.Images
{
    public interface IImageCommanderServices : IGenericCommanderServices<Image, ImageDto>
    {
        //Task<bool> CreatePostAsync(PostDto dto);
        new Task<bool> DeleteAsync(Guid dto);
        //Task<bool> UpdatePostAsync(PostDto dto);
    }
}