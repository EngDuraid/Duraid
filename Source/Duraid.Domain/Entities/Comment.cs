using System;

namespace Duraid.Domain.Entities
{
    public class Comment : EntityBase
    {
        public Guid CommentId { get; set; }
        public string CommentContent { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }

}
