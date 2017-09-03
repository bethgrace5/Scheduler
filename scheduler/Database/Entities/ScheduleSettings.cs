using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class ScheduleSettings
    {
        public virtual Weekday StartWeekday { get; set; }
        public int StartWeekdayId { get; set; }
        public int BusinessId { get; set; }
        public virtual Business Business { get; set; }
    }
}