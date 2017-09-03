using System;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.EnumEntities;

namespace scheduler.Domain.Entities
{
    public class TemporaryLocationHourChange : Entity
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