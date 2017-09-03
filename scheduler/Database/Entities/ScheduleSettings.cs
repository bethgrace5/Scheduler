
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class ScheduleSettings : EntityBase<int>
    {
        #region navigationProperties

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public int StartWeekdayId { get; set; }

        public virtual Weekday StartWeekday { get; set; }

        #endregion
    }
}