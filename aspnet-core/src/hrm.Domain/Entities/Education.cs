using hrm.Enum;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Education : FullAuditedEntity<Guid>
    {
        public Employee Employee { get; set; }
        public EducationBackground EducationBackground { get; set; }
        public string School { get; set; }
        public string Major { get; set; }
        public int GraduationYear { get; set; }
    }
}
