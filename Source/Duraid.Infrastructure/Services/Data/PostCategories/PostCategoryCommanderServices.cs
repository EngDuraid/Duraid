using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.PostCategories
{
    class PostCategoryCommanderServices : GenericCommanderServices<PostCategory, PostCategoryDTO>, IPostCategoryCommanderServices
    {
        readonly ICommander<PostCategory> _commader;
        readonly IMapper _mapper;
        readonly IFilter<PostCategory> _filter;
        public PostCategoryCommanderServices(ICommander<PostCategory> commader, IMapper mapper,
            IFilter<PostCategory> filter) : base(commader, mapper)
        {
            _commader = commader;
            _mapper = mapper;
            _filter = filter;
        }


        public override async Task<bool> CreateAsync(PostCategoryDTO dto)
        {
            try
            {
                CheckIfCategoryIdIsValid(dto);
                return await base.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateAsync(PostCategoryDTO dto)
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


        public async new Task<bool> DeleteAsync(Guid dto)
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
            return await _filter.Search(c => c.PostId != dto).AnyAsync();
        }

        #region Validation Methods

        private static void ValidateBeforeUpdate(PostCategoryDTO dto)
        {
            CheckIfPostIdIsValid(dto);
            CheckIfCategoryIdIsValid(dto);
        }

        private static void CheckIfCategoryIdIsValid(PostCategoryDTO dto)
        {
            if (dto.CategoryId == Guid.Empty)
                throw new ArgumentException("Invalid category id", nameof(dto.CategoryId));
        }

        private static void CheckIfPostIdIsValid(PostCategoryDTO dto)
        {
            if (dto.PostId == Guid.Empty)
                throw new ArgumentException("Invalid post id", nameof(dto.PostId));
        }

        #endregion
    }


}

