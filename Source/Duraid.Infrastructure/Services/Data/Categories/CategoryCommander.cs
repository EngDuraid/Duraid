using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    class CategoryCommander : ICategoryCommander
    {
        readonly ICommander<Category> _commander;
        readonly IMapper mapper;
        public CategoryCommander(ICommander<Category> commander, IMapper mapper)
        {
            _commander = commander;
            this.mapper = mapper;
        }

        public async Task<bool> CreateCategoryAsync(CategoryDTO dto)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(dto.CategoryName))
                    throw new ArgumentException("Invalid category name", nameof(dto.CategoryName));

                var entity = mapper.Map<Category>(dto);

                return await _commander.AddAsync(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<bool> UpdateCategoryAsync(CategoryDTO dto)
        {
            try
            {
                if (dto.CategoryId == Guid.Empty)
                    throw new ArgumentException("Invalid category id", nameof(dto.CategoryId));

                if (string.IsNullOrWhiteSpace(dto.CategoryName))
                    throw new ArgumentException("Invalid category name", nameof(dto.CategoryName));

                var entity = mapper.Map<Category>(dto);

                return await _commander.UpdateAsync(entity) > 0;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
