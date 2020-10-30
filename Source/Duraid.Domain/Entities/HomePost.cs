using System;

namespace Duraid.Domain.Entities
{
    public class HomePost
    {
        public Guid GuidId { get; set; }
        public Guid PostId { get; set; }
        public int PostOrder { get; set; }
        public DateTime? PostEndDate { get; set; }
        public bool IsDisabled { get; set; }
    }

}
