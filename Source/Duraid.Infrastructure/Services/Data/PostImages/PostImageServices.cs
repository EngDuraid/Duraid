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

namespace Duraid.Infrastructure.Services.Data.PostImages
{
    internal class PostImageServices:IPostImageServices
    {
        private readonly IFilter<PostImage> _filter;
        private readonly IMapper _mapper;

        public PostImageServices(IFilter<PostImage> filter, IMapper mapper)
        {
            _filter = filter;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostImageDto>> GetPostImagesByPostIdAsync(Guid postId)
        {
            return await _filter.Search(p => p.PostId == postId)
                .ProjectTo<PostImageDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<PostImageDto> GetPostImageAsync(Guid postImageId)
        {
            return await _filter.Search(p => p.PostImageId == postImageId)
                .ProjectTo<PostImageDto>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
    }
}
