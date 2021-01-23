using System;
using System.Collections.Generic;
using System.Text;

namespace Duraid.Common.DTO
{
    public class CategoryDto
    {
        public CategoryDto()
        {
            CategoryId=Guid.NewGuid();
        }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
