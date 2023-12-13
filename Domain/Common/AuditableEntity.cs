using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableEntity
    {
        public DateTime Created {  get; set; }
        
        public DateTime? LastModified { get; set; }
        public DateTime PasswordLastSet { get; set; }
    }
}
