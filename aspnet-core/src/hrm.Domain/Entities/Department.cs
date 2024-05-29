using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Department : FullAuditedEntity<Guid>
    {
        public string ShortName { get; set; }
        public string EnFullName { get; set; }
        public string ViFullName { get; set; }
        public Guid PropertyId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public Property Property { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<Position>? Positions { get; set; }
        public ICollection<OutletManagement>? OutletManagements { get; set; }

    }
}
