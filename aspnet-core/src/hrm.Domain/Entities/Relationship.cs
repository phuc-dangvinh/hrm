using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Relationship : FullAuditedEntity<Guid>
    {
        public hrm.Enum.Relationship Name { get; set; }
        public ICollection<RelativesContact>? RelativesContacts { get; set; }
        public ICollection<DeductionsDependent>? DeductionsDependents { get; set; }
    }
}
