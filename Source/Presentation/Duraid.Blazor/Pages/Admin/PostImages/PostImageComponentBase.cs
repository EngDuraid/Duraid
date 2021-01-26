using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duraid.Blazor.Pages.Admin.Posts;
using Duraid.Blazor.Services.Images;
using Duraid.Common.DTO;
using Microsoft.AspNetCore.Components;

namespace Duraid.Blazor.Pages.Admin.PostImages
{
    public class PostImageComponentBase:ComponentBase
    {
        #region Regions
        #region Fields

        #endregion

        #region Properties

        #endregion
        #region Services

        #endregion
        #region Parameters

        #endregion
        #region Actions

        #region Data actions

        #endregion

        #region Validation actions

        #endregion

        #region Functional actions

        #endregion
        #endregion


        #endregion

        #region Fields

        #endregion

        #region Properties
        public IList<ImageDto> Images { get; set; }
        public IList<PostImageDto> PostImages { get; set; }
        #endregion

        #region Services
        [Inject]
        private IImageServices ImageServices { get; set; }

        [Inject]
        private IImageHelper ImageHelper { get; set; }
        #endregion

        #region Parameters

        [Parameter]
        public PostDto Post { get; set; }

        #endregion
        #region Actions

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Images = new List<ImageDto>();
            PostImages = new List<PostImageDto>();
        }

        #region Data actions

        #endregion

        #region Validation actions

        #endregion

        #region Functional actions

        #endregion
        #region Dto Creations Actions
        private static PostImageDto CreatePostImage(Guid imageId, bool isDefaultPostImage)
        {
            return new() { ImageId = imageId, IsDefaultPostImage = isDefaultPostImage };
        }
        #endregion
        #endregion

        #region Event handler

        /// <summary>
        /// Event handler for inserting new photo from PhotoUploader child
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        protected internal void PhotoInserted(ImageDto image)
        {
            Images?.Add(image);
            var postImage = CreatePostImage(image.ImageId, PostImages?.Count < 1);
            PostImages.Add(postImage);
        }

        /// <summary>
        /// Event handler for deleting existing uploaded photo in the 
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>

        protected internal void PhotoDeleted(ImageDto image)
        {
            //Remove from images
            Images?.Remove(Images?.FirstOrDefault(p => p.ImageId == image.ImageId));

            //Remove from PostImages

            PostImages?.Remove(PostImages?.FirstOrDefault(p => p.ImageId == image.ImageId));
            var photo = PostImages?.FirstOrDefault();
            if (photo is null)
                return;
            photo.IsDefaultPostImage = true;
        }

        #endregion
    }
}
