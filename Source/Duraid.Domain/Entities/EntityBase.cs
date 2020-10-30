using System;

namespace Duraid.Domain.Entities
{
    public abstract class EntityBase
    {
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }

        public DateTime? EditedDate { get; set; }
        public Guid? EditedByUserId { get; set; }
    }

}
