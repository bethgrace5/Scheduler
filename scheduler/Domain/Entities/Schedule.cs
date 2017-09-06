using System;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Schedule : Entity
    {
        public DateTime StartDate { get; set; }

        public DateTime DatePublished { get; set; }

        public virtual Location Location { get; set; }

        public virtual User PublishedBy { get; set; }
    }
}