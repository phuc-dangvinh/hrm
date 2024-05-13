using System;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class OutletManagement : FullAuditedEntity<Guid>
    {
        public Guid CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
        public Guid PropertyId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }
        public Guid DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }
        public Guid OutletId { get; set; }
        [ForeignKey(nameof(OutletId))]
        public Outlet Outlet { get; set; }

    }
}
