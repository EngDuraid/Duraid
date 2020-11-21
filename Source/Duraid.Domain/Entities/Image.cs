using System;
using System.Collections.Generic;

namespace Duraid.Domain.Entities
{
    public class Image : EntityBase
    {
        public Image()
        {
            ImagePosts = new HashSet<PostImage>();
        }
        public Guid ImageId
        { get => Id; set => Id = value; }

        public string ImageDescription { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<PostImage> ImagePosts { get; set; }
    }
}
