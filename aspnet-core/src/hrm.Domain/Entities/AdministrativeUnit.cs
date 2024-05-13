using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class AdministrativeUnit : FullAuditedEntity<Guid>
    {
        public string Province { get; set; }
        public string District { get; set; }
        public string Commune { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<DeductionsDependent> DeductionsDependents { get; set; }
    }
}
