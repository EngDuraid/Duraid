using AutoMapper;
using Duraid.BusinessLogic.Data;
using Duraid.Common.DTO;
using Duraid.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Duraid.Infrastructure.Services.Data.Posts
{
    class PostCommanderServices : GenericCommanderServices<Post, PostDTO>, IPostCommanderServices
    {
        readonly IFilter<Post> _filter;
        public PostCommanderServices(IFilter<Post> filter, ICommander<Post> commander, IMapper mapper)
            : base(commander, mapper)
        {
            _filter = filter;
        }

        public override async Task<bool> CreateAsync(PostDTO dto)
        {
            try
            {
                CheckIfPostTitleIsValid(dto);
                CheckIfPostContentIsValid(dto);
                return await base.CreateAsync(dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public override async Task<bool> UpdateAsync(PostDTO dto)
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


        public  async new Task<bool> DeleteAsync(Guid dto)
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

        private static void ValidateBeforeUpdate(PostDTO dto)
        {
            CheckIfPostIdIsValid(dto);
            CheckIfPostTitleIsValid(dto);
            CheckIfPostContentIsValid(dto);
        }

        private static void CheckIfPostTitleIsValid(PostDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.PostTitle))
                throw new ArgumentException("Invalid post title", nameof(dto.PostTitle));
        }

        private static void CheckIfPostIdIsValid(PostDTO dto)
        {
            if (dto.PostId == Guid.Empty)
                throw new ArgumentException("Invalid post id", nameof(dto.PostId));
        }
        private static void CheckIfPostContentIsValid(PostDTO dto)
        {
            if (dto.PostId == Guid.Empty)
                throw new ArgumentException("Invalid post content", nameof(dto.PostContent));
        }

        #endregion

    }
}
