using System;
using System.Collections.Generic;

namespace Duraid.Domain.Entities.iCategory
{
    public interface ICategoryRelations : ICategory
    {
        ICollection<PostCategory> CategoryPosts { get; set; }
    }
}