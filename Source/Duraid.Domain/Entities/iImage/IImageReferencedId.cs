using System;

namespace Duraid.Domain.Entities.iImage
{
    public interface IImageReferencedId:IImageReferenced
    {
        Guid ImageId { get ; set ; }
    }
}