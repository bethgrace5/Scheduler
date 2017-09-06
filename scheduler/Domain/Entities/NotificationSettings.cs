using scheduler.Domain.Dictionaries;
using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities
{
    public class NotificationSettings : Entity
    {
        #region navigationProperties

        public virtual User User { get; set; }

        public virtual Notification Notification { get; set; }

        public virtual NotificationMedia NotificationMedia { get; set; }

        #endregion
    }
}