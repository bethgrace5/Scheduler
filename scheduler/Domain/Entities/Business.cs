using System;
using scheduler.Domain.Entities.Base;
using TimeZone = scheduler.Domain.Entities.Enums.TimeZone;

namespace scheduler.Domain.Entities
{
    public class Business : Entity
    {
        public string Name { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Fax { get; set; }

        public DateTime SubscriptionEndDate { get; set; }

        public DateTime SignUpDate { get; set; }

        public virtual TimeZone TimeZone { get; set; }

        public virtual Address BillingAddress { get; set; }

        public virtual Address HeadquarterAddress { get; set; }
    }
}