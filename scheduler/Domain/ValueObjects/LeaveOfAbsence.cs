using System;
using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class LeaveOfAbsence : ValueObject
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