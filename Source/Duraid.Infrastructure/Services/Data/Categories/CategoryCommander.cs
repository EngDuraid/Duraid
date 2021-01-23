using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Categories
{
    class CategoryCommander : GenericCommanderServices<Category, CategoryDto>, ICategoryCommander
    {

        readonly IFilter<Category> _filter;
        public CategoryCommander(ICommander<Category> commander, IMapper mapper, IFilter<Category> filter)
        : base(commander, mapper)
        {
            _filter = filter;
        }

        public override async Task<bool> CreateAsync(CategoryDto dto)
        {
            try
            {
                CheckIfCategoryNameIsValid(dto);
                return await base.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateAsync(CategoryDto dto)
        {
            try
            {
                ValidateBeforeUpdate(dto);
                return await base.UpdateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public new async Task<bool> DeleteAsync(Guid dto)
        {
            try
            {
                await base.DeleteAsync(dto);
                return await ConfirmeDeletionAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<bool> ConfirmeDeletionAsync(Guid dto)
        {
            return await _filter.Search(c => c.CategoryId != dto).AnyAsync();
        }

        #region Validation Methods

        private static void ValidateBeforeUpdate(CategoryDto dto)
        {
            CheckIfCategoryIdIsValid(dto);
            CheckIfCategoryNameIsValid(dto);
        }

        private static void CheckIfCategoryNameIsValid(CategoryDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CategoryName))
                throw new ArgumentException("Invalid category name", nameof(dto.CategoryName));
        }

        private static void CheckIfCategoryIdIsValid(CategoryDto dto)
        {
            if (dto.CategoryId == Guid.Empty)
                throw new ArgumentException("Invalid category id", nameof(dto.CategoryId));
        }
        #endregion

    }

}
