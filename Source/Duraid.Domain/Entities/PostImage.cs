using System;

namespace Duraid.Domain.Entities
{
    public class PostImage:EntityBase
    {
        public Guid PostImageId { get; set; }
        public bool IsDefaultPostImage { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public Guid ImageId { get; set; }
        public Image Image { get; set; }
    }
}
