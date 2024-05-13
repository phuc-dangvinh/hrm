using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Relationship : FullAuditedEntity<Guid>
    {
        public hrm.Enum.Relationship Name { get; set; }
        public ICollection<RelativesContact> RelativesContacts { get; set; }
        public ICollection<DeductionsDependent> DeductionsDependents { get; set; }
    }
}
