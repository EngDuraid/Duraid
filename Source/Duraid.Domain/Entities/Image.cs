using System;
using System.Collections.Generic;
using Duraid.Domain.Entities.iImage;

namespace Duraid.Domain.Entities
{
    public class Image : EntityBase,IImageRelations
    {
        public Image()
        {
            ImagePosts = new HashSet<PostImage>();
        }
        public Guid ImageId
        { get => Id; set => Id = value; }

        public string ImageDescription { get; set; }
        public string ImageName { get; set; }
        public string ImageDirectory { get; set; }
        public ICollection<PostImage> ImagePosts { get; set; }
    }
}
