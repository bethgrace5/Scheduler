using System;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Availability : ValueObject
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