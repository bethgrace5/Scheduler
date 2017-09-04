using System;
using scheduler.Domain.Entities;
using scheduler.Domain.EnumEntities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Availability : ValueObject<Availability>
    {

        public Availability(User user, Weekday weekday, DateTime startTime, DateTime endTime)
        {
            User = user;
            UserId = user.Id;
            Weekday = weekday;
            WeekdayId = weekday.Id;
            StartTime = startTime;
            EndTime = endTime;
        }

        public Availability(int userId, int weekdayId, DateTime startTime, DateTime endTime)
        {
            UserId = userId;
            WeekdayId = weekdayId;
            StartTime = startTime;
            EndTime = endTime;
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
                   && StartTime == other.StartTime;
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}