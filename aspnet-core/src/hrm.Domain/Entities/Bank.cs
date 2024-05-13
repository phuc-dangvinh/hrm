using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace hrm.Entities
{
    public class Bank : FullAuditedEntity<Guid>
    {
        public string ShortName { get; set; }
        public string EnFullName { get; set; }
        public string ViFullName { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}
