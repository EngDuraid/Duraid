using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class PostDto 
    {
        public PostDto()
        {
            PostId=Guid.NewGuid();
        }
        public Guid PostId { get; set; }
        public string PostTitle { get; set; }
        public string Description { get; set; }
        public string PostContent { get; set; }
    }
}
