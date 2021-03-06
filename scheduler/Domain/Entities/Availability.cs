﻿using System;
using scheduler.Domain.Entities.Base;
using scheduler.Domain.Entities.Enums;

namespace scheduler.Domain.Entities
{
    public class Availability : Entity
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual User User { get; set; }

        public virtual Weekday Weekday { get; set; }
    }
}