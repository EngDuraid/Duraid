using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Duraid.Common.DTO;

namespace Duraid.Infrastructure.Services.Data.Images
{
    public interface IImageServices
    {
        Task<IEnumerable<ImageDto>> GetImagesAsync();
        Task<ImageDto> GetImageAsync(Guid imageId);
    }
}