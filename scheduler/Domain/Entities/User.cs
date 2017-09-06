using System;
using System.Collections.Generic;
using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.ValueObjects;

namespace scheduler.Domain.Entities
{
    public class User : Entity
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Suffix { get; set; }

        public string Email { get; set; }

        public DateTime Birthdate { get; set; }

        public int MaxHoursPerWeek { get; set; }

        public int MinHoursPerWeek { get; set; }

        public string PrimaryPhone { get; set; }

        public string SecondaryPhone { get; set; }

        public int BusinessLedgerId { get; set; }

        public string Notes { get; set; }

        public bool Active { get; set; }

        public virtual Role Role { get; set; }

        public virtual Address Address { get; set; }

        public virtual Status Status { get; set; }

        public virtual ICollection<Availability> Availabilities { get; set; }
        public virtual ICollection<LocationHistory> LocationHistory { get; set; }
        public virtual ICollection<NotificationSettings> NotificationSettings { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<HasPosition> Positions { get; set; }
    }
}