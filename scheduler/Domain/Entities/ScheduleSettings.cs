using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.EnumEntities;

namespace scheduler.Domain.Entities
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