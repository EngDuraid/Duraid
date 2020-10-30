using System;
using System.Collections.Generic;

namespace Duraid.Domain.Entities
{
    public class Post:EntityBase
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }
        public Guid PostId { get; set; }
        public string PostTitle { get; set; }
        public string Description { get; set; }
        public string  PostContent { get; set; }

        public Guid CategotryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
