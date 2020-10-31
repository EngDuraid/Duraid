using System;

namespace Duraid.Domain.Entities
{
    public class PostCategory:EntityBase
    {
        public Guid PostCategoryId { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
