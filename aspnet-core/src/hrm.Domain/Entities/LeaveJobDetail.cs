using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class LeaveJobDetail : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public string ReasonDetail { get; set; }
        public Guid LeaveJobGroupId { get; set; }
        [ForeignKey(nameof(LeaveJobGroupId))]
        public LeaveJobGroup LeaveJobGroup { get; set; }
        public DateTime CompleteHandover {  get; set; }

    }
}
