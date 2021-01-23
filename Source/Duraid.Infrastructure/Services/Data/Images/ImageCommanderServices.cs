using System;
using System.Threading.Tasks;
using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duraid.Infrastructure.Services.Data.Images
{
    class ImageCommanderServices : GenericCommanderServices<Image, ImageDto>, IImageCommanderServices
    {
        readonly IFilter<Image> _filter;
        public ImageCommanderServices(IFilter<Image> filter, ICommander<Image> commander, IMapper mapper)
            : base(commander, mapper)
        {
            _filter = filter;
        }

        public override async Task<bool> CreateAsync(ImageDto dto)
        {
            try
            {
                CheckIfImageUrlIsValid(dto);
                //CheckIfPostContentIsValid(dto);
                return await base.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateAsync(ImageDto dto)
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
                return await ConfirmDeletionAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task<bool> ConfirmDeletionAsync(Guid dto)
        {
            return await _filter.Search(c => c.ImageId != dto).AnyAsync();
        }

        #region Validation Methods

        private static void ValidateBeforeUpdate(ImageDto dto)
        {
            CheckIfImageIdIsValid(dto);
            CheckIfImageUrlIsValid(dto);
            //CheckIfPostContentIsValid(dto);
        }

        private static void CheckIfImageUrlIsValid(ImageDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.ImageUrl))
                throw new ArgumentException("Invalid URL", nameof(dto.ImageUrl));
        }

        private static void CheckIfImageIdIsValid(ImageDto dto)
        {
            if (dto.ImageId == Guid.Empty)
                throw new ArgumentException("Invalid image id", nameof(dto.ImageId));
        }
       

        #endregion

    }
}