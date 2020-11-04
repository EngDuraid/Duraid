using System.Collections.Generic;

namespace Duraid.Domain.Entities.IPost
{
    public interface IPostRelations:IPost
    {
        ICollection<Comment> Comments { get; set; }
        ICollection<PostCategory> PostCategories { get; set; }
    }
}
