using System;
using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Availability : Entity
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual User User { get; set; }

        public virtual Weekday Weekday { get; set; }
    }
}