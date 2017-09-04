using System;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class TemporaryLocationHourChange : ValueObject<TemporaryLocationHourChange>
    {
        public TemporaryLocationHourChange(int locationId, int hourChangeReasonId, DateTime startDateTime,
            DateTime endDateTime, bool isOpen = false)
        {
            LocationId = locationId;
            HourChangeReasonId = hourChangeReasonId;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            IsOpen = isOpen;
        }

        public DateTime StartDateTime { get; }

        public DateTime EndDateTime { get; }

        public bool IsOpen { get; }

        public int HourChangeReasonId { get; }

        public virtual HourChangeReason HourChangeReason { get; }

        public long LocationId { get; }

        public virtual Location Location { get; }

        protected override bool EqualsCore(TemporaryLocationHourChange other)
        {
            return LocationId == other.LocationId
                   && StartDateTime == other.StartDateTime;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}