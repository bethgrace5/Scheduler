using System;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Availability : ValueObject<Availability>
    {

        public Availability(User user, Weekday weekday, DateTime startTime, DateTime endTime) 
            : this(user.Id, weekday.Id, startTime, endTime)
        {
            User = user;
            Weekday = weekday;
        }

        public Availability(long userId, long weekdayId, DateTime startTime, DateTime endTime)
        {
            if (startTime.Hour.CompareTo(endTime.Hour) > 0)
            {
                throw new ArgumentException("Start time must be before end time (hour)");
            }

            if (startTime.Hour.CompareTo(endTime.Hour) == 0 && startTime.Minute.CompareTo(endTime.Minute) > 0)
            {
                throw new ArgumentException("Start time must be before end time (minute)");
            }

            if (startTime.Hour.CompareTo(endTime.Hour) == 0 && startTime.Minute.CompareTo(endTime.Minute) == 0)
            {
                throw new ArgumentException($"Start time must be before end time (equal) Start Hour {startTime.Hour}, End Hour {EndTime.Hour}");
            }

            UserId = userId;
            WeekdayId = weekdayId;
            StartTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, startTime.Hour, startTime.Minute, 0, 0, DateTimeKind.Utc);
            EndTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, endTime.Hour, endTime.Minute, 0, 0, DateTimeKind.Utc);
        }

        public DateTime StartTime { get; }

        public DateTime EndTime { get; }

        public long UserId { get; }

        public virtual User User { get; }

        public long WeekdayId { get; }

        public virtual Weekday Weekday { get; }

        protected override bool EqualsCore(Availability other)
        {
            return UserId == other.UserId
                   && WeekdayId == other.WeekdayId
                   && StartTime == other.StartTime
                   && EndTime == other.EndTime;
        }

        protected override int GetHashCodeCore()
        {
            var hashCode = StartTime.GetHashCode();
            hashCode = (hashCode * 397) ^ EndTime.GetHashCode();
            hashCode = (hashCode * 397) ^ UserId.GetHashCode();
            hashCode = (hashCode * 397) ^ WeekdayId.GetHashCode();

            return hashCode;
        }
    }
}