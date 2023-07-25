using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public DateTime CreatedAt { get; set; }
        public int CreatedId { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedId { get; set; }
    }
}
