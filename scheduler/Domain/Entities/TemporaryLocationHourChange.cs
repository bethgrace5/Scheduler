using System;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.Enums;

namespace scheduler.Domain.Entities
{
    public class TemporaryLocationHourChange : Entity
    {
        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public bool IsOpen { get; set; }

        public virtual HourChangeReason HourChangeReason { get; set; }

        public virtual Location Location { get; set; }
    }
}