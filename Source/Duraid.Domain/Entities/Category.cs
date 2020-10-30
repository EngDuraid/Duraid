using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Duraid.Domain.Entities
{
    public class Category:EntityBase
    {
        public Category()
        {
            Posts = new HashSet<Post>();
        }
        public Guid CategoryId { get; set; }

        public string  CategoryName { get; set; }

        public ICollection<Post> Posts { get; set; }
    }

}
