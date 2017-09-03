using scheduler.Database.Enums;

namespace scheduler.Database.Entities.Relationships
{
    public class UserNotificationSettings
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int NotificaitonId { get; set; }

        public virtual Notification Notification { get; set; }

        public int MediaId { get; set; }

        public virtual NotificationMedia NotificationMedia { get; set; }

        #endregion
    }
}