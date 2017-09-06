using System;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class Absence : Entity
    {
        public bool IsApproved { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public virtual User RequestedBy { get; set; }

        public virtual User RespondedBy { get; set; }
    }
}