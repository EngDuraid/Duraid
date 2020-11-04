using AutoMapper;
using AutoMapper.QueryableExtensions;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
        {
            return await _filter.Search(c => c.CategoryId != null)
                .ProjectTo<CategoryDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<CategoryDTO> GetCategoryAsync(Guid categoryId)
        {
            return await _filter.Search(c => c.CategoryId == categoryId)
               .ProjectTo<CategoryDTO>(_mapper.ConfigurationProvider)
               .FirstOrDefaultAsync();
        }

        public async Task<bool> CategoryExistAsync(Guid categoryId)
        {
            return await _filter.Search(c => c.CategoryId == categoryId).AnyAsync();
        }
    }
}
