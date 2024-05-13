using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Citizen : FullAuditedEntity<Guid>
    {
        public Employee Employee { get; set; }
        public string Identification { get; set; }
        public DateTime IssuedDate { get; set; }
        public string IssuedBy { get; set; }
    }
}
