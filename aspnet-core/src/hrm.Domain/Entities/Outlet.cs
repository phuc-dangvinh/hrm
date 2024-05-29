using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Outlet : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
        public ICollection<OutletManagement>? OutletManagements { get; set; }
    }
}
