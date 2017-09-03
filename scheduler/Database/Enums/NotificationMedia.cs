using System.ComponentModel;
using scheduler.Database.Entities.Base;
using scheduler.Database.Enums.Base;

namespace scheduler.Database.Enums
{
    public enum NotificationMediaEnum
    {
        [Description("Email Notification")]
        Email = 1,

        [Description("Text Message Notification")]
        Text = 2,

        [Description("Push Notification")]
        Push = 3
    }

    public class NotificationMedia : ValueObject
    {
    }
}