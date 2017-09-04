using System;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.EnumEntities;
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

        #region navigationProperties

        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        #endregion
    }
}