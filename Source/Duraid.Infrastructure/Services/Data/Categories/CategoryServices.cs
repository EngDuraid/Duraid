using AutoMapper;
using AutoMapper.QueryableExtensions;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    class CategoryServices : ICategoryServices
    {
        readonly IMapper _mapper;
        readonly IFilter<Category> _filter;
        public CategoryServices(IMapper mapper, IFilter<Category> filter)
        {
            _mapper = mapper;
            _filter = filter;
        }

        public async Task<IEnumerable<CategoryDto>> GetCategoriesAsync()
        {
            return await _filter.Search(c => c.CategoryId != null)
                .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<CategoryDto> GetCategoryAsync(Guid categoryId)
        {
            return await _filter.Search(c => c.CategoryId == categoryId)
               .ProjectTo<CategoryDto>(_mapper.ConfigurationProvider)
               .FirstOrDefaultAsync();
        }

        public async Task<bool> CategoryExistAsync(Guid categoryId)
        {
            return await _filter.Search(c => c.CategoryId == categoryId).AnyAsync();
        }
    }

    
}
