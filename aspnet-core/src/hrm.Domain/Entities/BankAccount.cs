using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class BankAccount : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
        public string AccountNumber { get; set; }
        public Guid BankId { get; set; }
        [ForeignKey(nameof(BankId))]
        public Bank Bank { get; set; }
        public string BranchName { get; set; }
    }
}
