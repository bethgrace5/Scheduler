using System.ComponentModel;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Enums
{
    public enum NotificationEnum
    {
        [Description("New Schedule Has Been Published")]
        NewSchedulePublished = 1
    }

    public class Notification : ValueObject
    {
    }
}