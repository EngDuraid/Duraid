using System.Collections.Generic;

namespace Duraid.Domain.Entities.iImage
{
    public interface IImageRelations:IImage
    {
        ICollection<PostImage> ImagePosts { get; set; }
    }
}