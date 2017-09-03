using scheduler.Database.Entities.EnumEntities;
using scheduler.Database.ValueObjects;

namespace scheduler.Database.Entities.Relationships
{
    public class UserStatus
    {
        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int StatusId { get; set; }

        public virtual Status Status { get; set; }

        #endregion
    }
}