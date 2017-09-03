using scheduler.Database.Entities.Base;
using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class Location : EntityBase<int>
    {
        public string Name { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Fax { get; set; }

        #region navigationProperties

        public int TimeZoneId { get; set; }

        public virtual TimeZone TimeZone { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        #endregion
    }
}