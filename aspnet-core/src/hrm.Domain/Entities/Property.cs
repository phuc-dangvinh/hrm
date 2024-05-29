using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Property : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public Guid CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
        public ICollection<Department>? Departments { get; set; }
        public ICollection<OutletManagement>? OutletManagements { get; set; }
    }
}
