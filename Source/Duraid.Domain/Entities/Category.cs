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
            CategoryPosts = new HashSet<PostCategory>();
        }
        public Guid CategoryId { get; set; }

        public string  CategoryName { get; set; }

        public ICollection<PostCategory> CategoryPosts { get; set; }
    }

}
