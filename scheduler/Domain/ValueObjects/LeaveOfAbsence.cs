using System;
using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class LeaveOfAbsence : ValueObject<LeaveOfAbsence>
    {
        public LeaveOfAbsence(int requestedById, int respondedById, DateTime startDateTime, DateTime endDateTime,
            bool isApproved = false)
        {
            RequestedById = requestedById;
            RespondedById = respondedById;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            IsApproved = isApproved;
        }

        public bool IsApproved { get; }

        public DateTime StartDateTime { get; }

        public DateTime EndDateTime { get; }

        public int RequestedById { get; set; }

        public virtual User RequestedBy { get; set; }

        public int RespondedById { get; set; }

        public virtual User RespondedBy { get; set; }


        protected override bool EqualsCore(LeaveOfAbsence other)
        {
            return RequestedById == other.RequestedById
                   && RespondedById == other.RespondedById
                   && IsApproved == other.IsApproved
                   && StartDateTime == other.StartDateTime
                   && EndDateTime == other.EndDateTime;
        }

        protected override int GetHashCodeCore()
        {
            var hashCode = StartDateTime.GetHashCode();
            hashCode = (hashCode * 397) ^ EndDateTime.GetHashCode();
            hashCode = (hashCode * 397) ^ IsApproved.GetHashCode();
            hashCode = (hashCode * 397) ^ RequestedById;
            hashCode = (hashCode * 397) ^ RespondedById;
            hashCode = (hashCode * 397) ^ IsApproved.GetHashCode();

            return hashCode;
        }
    }
}