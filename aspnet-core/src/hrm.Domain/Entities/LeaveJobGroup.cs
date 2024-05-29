using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class LeaveJobGroup : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<LeaveJobDetail>? LeaveJobDetails { get; set; }
    }
}
