using System;
using scheduler.Database.Entities.Base;
using scheduler.Database.Entities.EnumEntities;
using scheduler.Database.ValueObjects;

namespace scheduler.Database.Entities
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