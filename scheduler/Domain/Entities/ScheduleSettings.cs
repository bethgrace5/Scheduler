using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class ScheduleSettings : Entity
    {
        public virtual Business Business { get; set; }

        public virtual Weekday StartWeekday { get; set; }
    }
}