using System;

namespace scheduler.Database.Entities
{
    public class LeaveOfAbsence
    {
        public int Id { get; set; }

        public int RequestedById { get; set; }

        public int RespondedById { get; set; }

        public bool IsApproved { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public virtual User RequestedBy { get; set; }

        public virtual User RespondedBy { get; set; }
    }
}