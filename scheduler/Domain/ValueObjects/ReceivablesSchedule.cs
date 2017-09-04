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
                   && Title == other.Title;
        }

        protected override int GetHashCodeCore()
        {
            throw new System.NotImplementedException();
        }
    }
}