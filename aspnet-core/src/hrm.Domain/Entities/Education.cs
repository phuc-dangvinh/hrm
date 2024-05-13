using hrm.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
