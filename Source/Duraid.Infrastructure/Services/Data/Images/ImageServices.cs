using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duraid.Infrastructure.Services.Data.Images
{
    internal class ImageServices : IImageServices
    {
        readonly IFilter<Image> _filter;
        readonly IMapper _mapper;

        public ImageServices(IFilter<Image> filter, IMapper mapper)
        {
            _filter = filter;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ImageDto>> GetImagesAsync()
        {
            return await _filter.Search(p => p.ImageId != null)
                .ProjectTo<ImageDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<ImageDto> GetImageAsync(Guid imageId)
        {
            return await _filter.Search(p => p.ImageId == imageId)
                .ProjectTo<ImageDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
    }
}
