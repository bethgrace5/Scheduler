using System.Collections.Generic;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Permission : Entity
    {
        public virtual ICollection<User> Users { get; set; }
    }
}