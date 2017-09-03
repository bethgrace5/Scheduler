using System.ComponentModel;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums.Base;

namespace scheduler.Database.Enums
{
    public enum HourChangeReasonEnum
    {
        [Description("No Reason Specified")]
        None = 1,

        [Description("Holiday")]
        Holiday = 2
    }

    public class HourChangeReason : ValueObject
    {
    }
}