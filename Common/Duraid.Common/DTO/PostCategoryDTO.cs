using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class PostCategoryDto
    {
        public PostCategoryDto()
        {
            PostCategoryId=Guid.NewGuid();
        }
        public Guid PostCategoryId { get; set; }
        public Guid PostId { get; set; }

        public Guid CategoryId { get; set; }
        public string  CategoryName { get; set; }
    }
}
