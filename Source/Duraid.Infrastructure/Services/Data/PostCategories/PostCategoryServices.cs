using AutoMapper;
using AutoMapper.QueryableExtensions;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.PostCategories
{
    class PostCategoryServices : IPostCategoryServices
    {

        readonly IMapper _mapper;
        readonly IFilter<PostCategory> _filter;
        public PostCategoryServices(IMapper mapper, IFilter<PostCategory> filter)
        {
            _mapper = mapper;
            _filter = filter;
        }

        public async Task<IEnumerable<PostCategoryDTO>> GetPostCategoriesByPostIdAsync(Guid postId)
        {
            return await _filter.Search(c => c.PostId == postId)
                .ProjectTo<PostCategoryDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
        public async Task<IEnumerable<PostCategoryDTO>> GetPostCategoriesByCategoryIdAsync(Guid categoryId)
        {
            return await _filter.Search(c => c.CategoryId == categoryId)
                .ProjectTo<PostCategoryDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<PostCategoryDTO> GetPostCategoryAsync(Guid PostCategoryId)
        {
            return await _filter.Search(c => c.PostCategoryId == PostCategoryId)
               .ProjectTo<PostCategoryDTO>(_mapper.ConfigurationProvider)
               .FirstOrDefaultAsync();
        }

        public async Task<bool> PostCategoryExistAsync(Guid postCategoryId)
        {
            return await _filter.Search(c => c.PostCategoryId == postCategoryId).AnyAsync();
        }
    }
}
