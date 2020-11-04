using System;

namespace Duraid.Domain.Entities.IPost
{
    public interface IPost: IPostReferencedId
    {
        string Description { get; set; }
        string PostContent { get; set; }
    }
}
