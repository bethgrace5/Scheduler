using System;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.EnumEntities;

namespace scheduler.Domain.Entities
{
    public class Availability : Entity
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int WeekdayId { get; set; }

        public virtual Weekday Weekday { get; set; }

        #endregion

    }
}