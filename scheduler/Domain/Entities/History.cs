using System;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class LocationHistory : Entity
    {
        public DateTime DateEmployed { get; set; }

        public DateTime DateUnemployed { get; set; }

        public virtual Location Location { get; set; }
    }
}