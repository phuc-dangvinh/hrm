using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Role : FullAuditedEntity<Guid>
    {
        public hrm.Enum.Role Name { get; set; }
    }
}
