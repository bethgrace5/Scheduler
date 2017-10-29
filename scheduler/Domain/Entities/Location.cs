using System.Collections.Generic;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.Enums;

namespace scheduler.Domain.Entities
{
    public class Location : Entity
    {
        public string Name { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Fax { get; set; }

        public virtual TimeZone TimeZone { get; set; }

        public virtual Business Business { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Position> Positions { get; set; }

        public virtual ICollection<TemporaryLocationHourChange> TemporaryLocationHourChanges { get; set; }
    }
}