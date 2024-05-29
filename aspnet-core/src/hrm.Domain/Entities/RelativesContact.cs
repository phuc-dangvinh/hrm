using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class RelativesContact : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string? Email { get; set; }
        public Guid RelationshipId { get; set; }
        [ForeignKey(nameof(RelationshipId))]
        public Relationship Relationship { get; set; }
        public string? OtherRelationshipName { get; set; }


    }
}
