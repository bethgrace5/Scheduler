using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.Enums;

namespace scheduler.Domain.Entities
{
    public class ScheduleSettings : Entity
    {
        public virtual Business Business { get; set; }

        public virtual Weekday StartWeekday { get; set; }
    }
}