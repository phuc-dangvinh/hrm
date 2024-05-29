using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Citizen : FullAuditedEntity<Guid>
    {
        public Employee Employee { get; set; }
        public string Identification { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
    }
}
