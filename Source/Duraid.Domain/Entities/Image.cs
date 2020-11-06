using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Duraid.Domain.Entities
{
    public class Image : EntityBase
    {
        public Image()
        {
            PostImages = new HashSet<PostImage>();
        }
        public Guid ImageId
        { get => Id; set => Id = value; }

        public string ImageDescription { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<PostImage> PostImages { get; set; }
    }
}
