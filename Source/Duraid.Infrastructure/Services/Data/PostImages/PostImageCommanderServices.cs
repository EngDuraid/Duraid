using System;
using System.Threading.Tasks;
using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duraid.Infrastructure.Services.Data.PostImages
{
    internal class PostImageCommanderServices : GenericCommanderServices<PostImage, PostImageDto>,IPostImageCommanderServices
    {
        readonly IFilter<PostImage> _filter;
        public PostImageCommanderServices(IFilter<PostImage> filter, ICommander<PostImage> commander, IMapper mapper)
            : base(commander, mapper)
        {
            _filter = filter;
        }

        public override async Task<bool> CreateAsync(PostImageDto dto)
        {
            try
            {

                ValidateBeforeCrateOrUpdate(dto);
                return await base.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateAsync(PostImageDto dto)
        {
            try
            {
                ValidateBeforeCrateOrUpdate(dto);
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
                return await ConfirmDeletionAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<bool> ConfirmDeletionAsync(Guid dto)
        {
            return await _filter.Search(c => c.PostImageId != dto).AnyAsync();
        }

        #region Validation Methods

        private static void ValidateBeforeCrateOrUpdate(PostImageDto dto)
        {
            CheckIfImageIdIsValid(dto);
            CheckIfPostIdIsValid(dto);
            //CheckIfPostContentIsValid(dto);
        }


        private static void CheckIfImageIdIsValid(PostImageDto dto)
        {
            if (dto.ImageId == Guid.Empty)
                throw new ArgumentException("Invalid image id", nameof(dto.ImageId));

        }

        private static void CheckIfPostIdIsValid(PostImageDto dto)
        {
            if (dto.PostId == Guid.Empty)
                throw new ArgumentException("Invalid post id", nameof(dto.PostId));
        }


        #endregion

    }
}