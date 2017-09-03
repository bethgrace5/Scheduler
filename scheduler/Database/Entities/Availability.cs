using System;
using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class Availability
    {
        public int UserId { get; set; }

        public int WeekdayId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual User User { get; set; }

        public virtual Weekday Weekday { get; set; }

    }
}