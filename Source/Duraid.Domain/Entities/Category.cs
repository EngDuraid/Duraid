using Duraid.Domain.Entities.iCategory;
using System;
using System.Collections.Generic;

namespace Duraid.Domain.Entities
{
    public class Category : EntityBase, ICategoryRelations
    {
        public Category()
        {
            CategoryPosts = new HashSet<PostCategory>();
        }

        public Guid CategoryId
        {
            get => Id;
            set => Id = value;
        }

        public string CategoryName { get; set; }

        public ICollection<PostCategory> CategoryPosts { get; set; }
    }

}
