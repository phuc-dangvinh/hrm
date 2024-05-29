using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Level : FullAuditedEntity<Guid>
    {
        public string GroupLevel { get; set; }
        public int CompanyLevel { get; set; }
        public ICollection<Position>? Positions { get; set; }
    }
}
