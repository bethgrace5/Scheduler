using System;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class TemporaryLocationHourChange : ValueObject
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string ReasonId { get; set; }
        public bool IsOpen { get; set; }

        #region navigationProperties

        public int HourChangeReasonId { get; set; }

        public virtual HourChangeReason HourChangeReason { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}