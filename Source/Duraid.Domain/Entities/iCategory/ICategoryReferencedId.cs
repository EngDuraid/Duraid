using System;

namespace Duraid.Domain.Entities.iCategory
{
    public interface ICategoryReferencedId : ICategoryReferenced
    {
        Guid CategoryId { get; set; }
    }
}