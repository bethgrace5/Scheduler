using System.ComponentModel.DataAnnotations.Schema;
using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Position : ValueObject<Position>
    {
        public Position(long locationId, string name, string area = "")
        {
            LocationId = locationId;
            Name = name.Trim();
            Area = area.Trim();
        }

        public string Name { get; }

        public string Area { get; }

        public long LocationId { get; }

        public virtual Location Location { get; }

        protected override bool EqualsCore(Position other)
        {
            return LocationId == other.LocationId
                   && Name == other.Name
                   && Area == other.Area;
        }

        protected override int GetHashCodeCore()
        {
            int hashCode = (int) LocationId;

            hashCode = (hashCode * 397) ^ Name.GetHashCode();
            hashCode = (hashCode * 397) ^ Area.GetHashCode();

            return hashCode;
        }
    }
}