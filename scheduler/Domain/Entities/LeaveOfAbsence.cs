using System;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class LeaveOfAbsence : Entity
    {
        public bool IsApproved { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        #region navigationProperties

        public int RequestedById { get; set; }

        public virtual User RequestedBy { get; set; }

        public int RespondedById { get; set; }

        public virtual User RespondedBy { get; set; }

        #endregion

    }
}