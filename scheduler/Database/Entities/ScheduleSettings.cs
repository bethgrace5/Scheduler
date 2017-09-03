
using scheduler.Database.Entities.Base;
using scheduler.Database.Entities.EnumEntities;
using scheduler.Database.ValueObjects;

namespace scheduler.Database.Entities
{
    public class ScheduleSettings : Entity
    {
        #region navigationProperties

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public int StartWeekdayId { get; set; }

        public virtual Weekday StartWeekday { get; set; }

        #endregion
    }
}