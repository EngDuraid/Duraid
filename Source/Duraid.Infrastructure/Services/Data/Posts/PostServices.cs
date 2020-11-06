using AutoMapper;
using AutoMapper.QueryableExtensions;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Posts
{
    class PostServices : IPostServices
    {
        readonly IFilter<Post> _filter;
        readonly IMapper _mapper;
        
        public PostServices(IFilter<Post> filter, IMapper mapper)
        {
            _filter = filter;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PostDTO>> GetPostsAsync()
        {
            return await _filter.Search(p => p.PostId != null)
                .ProjectTo<PostDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<PostDTO> GetPostAsync(Guid postId)
        {
            return await _filter.Search(p => p.PostId == postId)
                .ProjectTo<PostDTO>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
    }
}
