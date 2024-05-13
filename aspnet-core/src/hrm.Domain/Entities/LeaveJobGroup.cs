using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class LeaveJobGroup : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<LeaveJobDetail> LeaveJobDetails { get; set; }
    }
}
