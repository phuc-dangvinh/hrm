using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Address : FullAuditedEntity<Guid>
    {
        public Employee Employee { get; set; }
        public Guid AdministrativeUnitId { get; set; }
        [ForeignKey(nameof(AdministrativeUnitId))]
        public AdministrativeUnit AdministrativeUnit { get; set; }
        public string? MoreDetail { get; set; }
    }
}
