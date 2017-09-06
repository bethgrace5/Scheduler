using System;
using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities.Base;

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