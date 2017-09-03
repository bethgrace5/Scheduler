using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public int BusinessId { get; set; }

        public int TimeZoneId { get; set; }

        public int AddressId { get; set; }

        public string Name { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Fax { get; set; }

        public virtual TimeZone TimeZone { get; set; }

        public virtual Business Business { get; set; }

        public virtual Address Address { get; set; }
    }
}