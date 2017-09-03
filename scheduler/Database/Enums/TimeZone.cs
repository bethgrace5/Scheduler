using System.ComponentModel;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Enums
{
    public enum TimeZoneEnum
    {
        [Description("Pacific Standard Time")]
        Pacific = 1,
    }

    public class TimeZone : ValueObject
    {
        
    }
}