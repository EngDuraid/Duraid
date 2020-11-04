using System;

namespace Duraid.Domain.Entities
{
    public class Comment : EntityBase
    {
        public Guid CommentId
        {
            get => Id;
            set => Id = value;
        }
        public string CommentContent { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }

}
