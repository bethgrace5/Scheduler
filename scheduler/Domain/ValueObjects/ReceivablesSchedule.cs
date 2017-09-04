using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class ReceivablesSchedule : ValueObject<ReceivablesSchedule>
    {
        public ReceivablesSchedule(string title, long locationId, bool monday, bool tuesday, bool wednesday, bool thursday, bool friday,
            bool saturday, bool sunday)
        {
            Title = title;
            LocationId = locationId;
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            Saturday = saturday;
            Sunday = sunday;
        }

        public string Title { get; }

        public bool Monday { get; }

        public bool Tuesday { get; }

        public bool Wednesday { get; }

        public bool Thursday { get; }

        public bool Friday { get; }

        public bool Saturday { get; }

        public bool Sunday { get; }

        public long LocationId { get; set; }

        public virtual Location Location { get; set; }

        protected override bool EqualsCore(ReceivablesSchedule other)
        {
            return LocationId == other.LocationId
                   && Title == other.Title
                   && Monday == other.Monday
                   && Tuesday == other.Tuesday
                   && Wednesday == other.Wednesday
                   && Thursday == other.Thursday
                   && Friday == other.Friday
                   && Saturday == other.Saturday
                   && Sunday == other.Sunday;
        }

        protected override int GetHashCodeCore()
        {
            var hashCode = (LocationId.GetHashCode());
            hashCode = (hashCode * 397) ^ Title.GetHashCode();
            hashCode = (hashCode * 397) ^ Monday.GetHashCode();
            hashCode = (hashCode * 397) ^ Tuesday.GetHashCode();
            hashCode = (hashCode * 397) ^ Wednesday.GetHashCode();
            hashCode = (hashCode * 397) ^ Thursday.GetHashCode();
            hashCode = (hashCode * 397) ^ Friday.GetHashCode();
            hashCode = (hashCode * 397) ^ Saturday.GetHashCode();
            hashCode = (hashCode * 397) ^ Sunday.GetHashCode();

            return hashCode;
        }
    }
}