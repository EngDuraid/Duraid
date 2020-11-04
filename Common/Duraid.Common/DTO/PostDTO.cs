using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class PostDTO 
    {
        public Guid PostId { get; set; }
        public string PostTitle { get; set; }
        public string Description { get; set; }
        public string PostContent { get; set; }

        
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
