using System;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class UserScheduledForShift : Entity
    {
        public DateTime Date { get; set; }

        public virtual User User { get; set; }

        public virtual Shift Shift { get; set; }
    }
}