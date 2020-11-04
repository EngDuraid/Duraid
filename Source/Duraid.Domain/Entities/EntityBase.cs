using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duraid.Domain.Entities
{
    public abstract class EntityBase
    {
        [NotMapped]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }

        public DateTime? EditedDate { get; set; }
        public Guid? EditedByUserId { get; set; }
    }

}
