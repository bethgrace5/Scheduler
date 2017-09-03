using System;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class Availability : EntityBase<int>
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