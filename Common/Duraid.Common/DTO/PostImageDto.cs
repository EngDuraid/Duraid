using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class PostImageDto
    {
        public PostImageDto()
        {
            PostImageId = Guid.NewGuid();
        }
        public Guid PostImageId { get; set; }
        public bool IsDefaultPostImage { get; set; }
        public Guid PostId { get; set; }
        public Guid ImageId { get; set; }
    }
}
