using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class DeductionsDependent : FullAuditedEntity<Guid>
    {
        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
        public string FullName { get; set; }
        public string? TaxCode { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Identification { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
        public Guid AdministrativeUnitId { get; set; }
        [ForeignKey(nameof(AdministrativeUnitId))]
        public AdministrativeUnit AdministrativeUnit { get; set; }
        public string MoreAddressDetail { get; set; }
        public Guid RelationshipId { get; set; }
        [ForeignKey(nameof(RelationshipId))]
        public Relationship Relationship { get; set; }
    }
}
