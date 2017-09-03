﻿using System;
using scheduler.Database.Enums;

namespace scheduler.Database.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Suffix { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public int MaxHoursPerWeek { get; set; }
        public int MinHoursPerWeek { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public int BusinessLedgerId { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
    }
}