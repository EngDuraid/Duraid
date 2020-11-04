using System;

namespace Duraid.Domain.Entities.IPost
{
    public interface IPostReferencedId : IPostReferenced
    {
        Guid PostId { get; set; }

    }
}
