using System.Collections.Generic;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Position : Entity
    {
        public string Name { get; set; }

        public string Area { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}