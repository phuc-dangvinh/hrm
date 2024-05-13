using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Position : FullAuditedEntity<Guid>
    {
        public string EnName { get; set; }
        public string ViName { get; set; }
        public Guid DepartmentId { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }
        public Guid LevelId { get; set; }
        [ForeignKey(nameof(LevelId))]
        public Level Level { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
