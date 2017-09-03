using System;
using scheduler.Database.Entities.Base;
using TimeZone = scheduler.Database.Enums.TimeZone;

namespace scheduler.Database.Entities
{
    public class Business : EntityBase<int>
    {
        public string Name { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public string Fax { get; set; }

        public DateTime SubscriptionEndDate { get; set; }

        public DateTime SignUpDate { get; set; }

        #region navigationProperties

        public int TimeZoneId { get; set; }

        public virtual TimeZone TimeZone { get; set; }

        public int BillingAddressId { get; set; }

        public virtual Address BillingAddress { get; set; }

        public int HeadquarterAddressId { get; set; }

        public virtual Address HeadquarterAddress { get; set; }

        #endregion
    }
}