using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class PostCategoryDTO
    {
        public Guid PostCategoryId { get; set; }
        public Guid PostId { get; set; }

        public Guid CategoryId { get; set; }
        public string  CategoryName { get; set; }
    }
}
