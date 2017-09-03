﻿using System.ComponentModel;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums.Base;

namespace scheduler.Database.Enums
{
    public enum StatusEnum
    {
        [Description("Active")]
        Active = 1,

        [Description("Disabled")]
        Disabled = 2
    }

    public class Status : ValueObject
    {
    }
}