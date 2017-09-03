using System;

namespace scheduler.Database.Entities.Relationships
{
    public class UserPosition
    {
        public DateTime DateAcquired { get; set; }
        public DateTime DateRemoved { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsTraining { get; set; }

        #region navigationProperties

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }

        #endregion
    }
}